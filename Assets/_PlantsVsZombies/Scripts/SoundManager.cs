using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    public static SoundManager Instance
    {
        get
        {
            return ((SoundManager)mInstance);
        }
        set
        {
            mInstance = value;
        }
    }
    //referencia a nuestro audio soure
    public AudioSource audioSource;
    private void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.mute = false;
    }
    /// <summary>
    /// metodo que se llamam para empezar a sonar la musica;
    /// </summary>
    /// <param name="audioClip"></param>
    public void StartPlay(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();

    }

}
