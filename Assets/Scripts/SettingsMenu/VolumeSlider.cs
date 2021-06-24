using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : MonoBehaviour {

    public AudioMixerGroup mixerGroup;

    private Slider slider;

    private void Awake() {
        slider = GetComponent<Slider>();
    }

    private void Start() {
        float mixerValue = MixerHandler.instance.GetVolume(mixerGroup);
        slider.value = MixerToSlider(mixerValue);
        slider.onValueChanged.AddListener(delegate {
            SetVolume(slider.value);
        });
    }

    public void SetVolume(float sliderValue) {
        float volume = SliderToMixer(sliderValue);
        MixerHandler.instance.SetVolume(mixerGroup, volume);
        Settings.StoreVolume(mixerGroup, volume);
    }

    private float SliderToMixer(float sliderValue) {
        return Mathf.Log10(sliderValue) * 20;
    }

    private float MixerToSlider(float mixerValue) {
        return Mathf.Pow(10, mixerValue / 20);
    }

}
