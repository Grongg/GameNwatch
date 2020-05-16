using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip timeTick;
    public AudioClip speedUp;
    public AudioClip Start;
    public AudioClip Death;
    public AudioClip Music;
    public void PlaySound(AudioClip sound)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.volume = 0.1f;
        audioSource.PlayOneShot(sound);
    }
    public void PlayMusic()
    {
        GameObject soundGameObject = new GameObject("Music");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.volume = 0.2f;
        audioSource.clip = Music;
        audioSource.loop = true;
        audioSource.Play();
    }
}
