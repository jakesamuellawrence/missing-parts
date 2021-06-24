using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;

public static class Settings {

    private static string resolutionWidthKey = "res_width";
    private static string resolutionHeightKey = "res_height";
    private static string resolutionRefreshKey = "res_refresh";
    private static string fullscreenKey = "fullscreen";

    public static void StoreResolution(int width, int height, int refreshRate) {
        PlayerPrefs.SetInt(resolutionWidthKey, width);
        PlayerPrefs.SetInt(resolutionHeightKey, height);
        PlayerPrefs.SetInt(resolutionRefreshKey, refreshRate);
    }

    public static void StoreFullscreen(bool isFullscreen) {
        PlayerPrefs.SetInt(fullscreenKey, isFullscreen ? 1 : 0);
    }

    public static void StoreVolume(AudioMixerGroup group, float volume) {
        string key = MixerHandler.instance.VolumeParameterFromGroup(group);
        PlayerPrefs.SetFloat(key, volume);
    }

    public static void SaveSettings() {
        PlayerPrefs.Save();
    }

    public static void LoadSettings() {
        LoadResolution();
        LoadFullscreen();
        AudioMixerGroup[] groups = MixerHandler.instance.GetGroups();
        foreach (AudioMixerGroup group in groups) {
            LoadVolume(group);
        }
    }

    public static void LoadResolution() {
        if (PlayerPrefs.HasKey(resolutionHeightKey) && PlayerPrefs.HasKey(resolutionWidthKey) && PlayerPrefs.HasKey(resolutionRefreshKey)) {
            int width = PlayerPrefs.GetInt(resolutionWidthKey);
            int height = PlayerPrefs.GetInt(resolutionHeightKey);
            int refresh = PlayerPrefs.GetInt(resolutionRefreshKey);
            Screen.SetResolution(width, height, Screen.fullScreen, refresh);
        } else {
            Debug.Log("Doing default res");
            Resolution native = Screen.resolutions.Last<Resolution>();
            Screen.SetResolution(native.width, native.height, Screen.fullScreen, native.refreshRate);
        }
    }

    public static void LoadFullscreen() {
        if (PlayerPrefs.HasKey(fullscreenKey)) {
            bool isFullscreen = PlayerPrefs.GetInt(fullscreenKey) == 1;
            Screen.fullScreen = isFullscreen;
        } else {
            Screen.fullScreen = true;
        }
    }

    public static void LoadVolume(AudioMixerGroup group) {
        string key = MixerHandler.instance.VolumeParameterFromGroup(group);
        if (PlayerPrefs.HasKey(key)) {
            float vol = PlayerPrefs.GetFloat(key);
            MixerHandler.instance.SetVolume(group, vol);
        } else {
            MixerHandler.instance.SetVolume(group, 0);
        }
    }

}
