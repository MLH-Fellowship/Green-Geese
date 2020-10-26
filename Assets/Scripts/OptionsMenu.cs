using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// must be using Unity Engine Audio to call on the exposed parameter of the Unity Audio Mixer
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    // to get a float value for "volume" using the slider
    public void SetVolume(float volume)
    {
        // sets the AudioMixer value to volume 
        audioMixer.SetFloat("volume", volume);
    }
}
