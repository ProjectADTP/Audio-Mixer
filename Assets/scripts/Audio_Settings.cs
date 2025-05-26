using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_Settings : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;

    public void ChangeSoundVolume(float volume)
    {
        _audioMixer.audioMixer.SetFloat("SoundVolume", Mathf.Log10(volume) * 20);
    }

    public void ChangeMusicVolume(float volume)
    {
        _audioMixer.audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
    }
    
    public void ChangeUIVolume(float volume)
    {
        _audioMixer.audioMixer.SetFloat("UIVolume", Mathf.Log10(volume) * 20);
    }

    public void ToggleMasterVolume(bool enabled)
    {
        if (enabled)
        {
            _audioMixer.audioMixer.SetFloat("MasterVolume", 0);
        }
        else
        {
            _audioMixer.audioMixer.SetFloat("MasterVolume", -80);
        }
    }
}
