using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Audio;

public class MixerHandler : MonoBehaviour {

    public static MixerHandler instance;

    [SerializeField]
    private AudioMixer main = null;

    [Tooltip("Make sure all volume parameters in the main mixer are named as <prefix>_<groupname>, all lowercase")]
    public string volumeParameterPrefix = "volume";

    public void SetVolume(AudioMixerGroup group, float volume) {
        main.SetFloat(VolumeParameterFromGroup(group), volume);
    }

    public float GetVolume(AudioMixerGroup group) {
        float volume;
        main.GetFloat(VolumeParameterFromGroup(group), out volume);
        return volume;
    }

    public string VolumeParameterFromGroup(AudioMixerGroup group) {
        return volumeParameterPrefix + "_" + group.name.ToLower();
    }

    public AudioMixerGroup[] GetGroups() {
        AudioMixerGroup[] groups = main.FindMatchingGroups(string.Empty);
        Debug.Log("Getting Groups: " + groups.Length);
        foreach (AudioMixerGroup group in groups) {
            Debug.Log(group.name);
        }
        return groups;
    }

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }
    }

}
