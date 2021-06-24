using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicTimer : MonoBehaviour {

    public bool started = false;

    private AudioSource source;

    public delegate void OnMusicFinished();
    public OnMusicFinished onMusicFinished;

    private void Awake() {
        source = GetComponent<AudioSource>();
    }

    private void Update() {
        if (!source.isPlaying && started) {
            onMusicFinished?.Invoke();
            started = false;
        }

        source.pitch = Time.timeScale;
    }

    public float GetTimeLeft() {
        if (source == null) {
            return 0;
        }
        return source.clip.length - source.time;
    }

    public void SetSong(AudioClip clip) {
        source.clip = clip;
    }

    public void SetLooping(bool looping) {
        source.loop = looping;
    }

    public void StartTimer() {
        started = true;
        source.Play();
    }

}
