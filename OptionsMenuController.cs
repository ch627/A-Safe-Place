using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenuController : MonoBehaviour
{
    public AudioMixer mainMixer; // stores a refrence to the main mixer.
    public AudioMixer sfxMixer; // stores a refrence to the sfx mixer.

    // change the volume of main mixer
    public void ChangeVolume(float mainVolume)
    {
        mainMixer.SetFloat("mainVolume", mainVolume); // adjust the main volume.
        Debug.Log(mainVolume);
    }
    // change the sfx volume.
    public void ChangeSFXVolume(float sfxVolume)
    {
        sfxMixer.SetFloat("sfxVolume", sfxVolume); // adjust the sfx volume.

        Debug.Log(sfxVolume);
    }

}
