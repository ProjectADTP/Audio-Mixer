using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ToggleAudioMaster : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;
    [SerializeField] private Toggle _masterSound;

    private int _maxVolume = -80;
    private int _minVolume = 0;

    private string _masterVolume = "MasterVolume";

    private void OnEnable()
    {
        _masterSound.onValueChanged.AddListener(ToggleMasterVolume);
    }

    private void OnDisable()
    {
        _masterSound.onValueChanged.RemoveListener(ToggleMasterVolume);
    }

    private void ToggleMasterVolume(bool isOn)
    {
        if (isOn)
        {
            _audioMixer.audioMixer.SetFloat(_masterVolume, _minVolume);
        }
        else
        {
            _audioMixer.audioMixer.SetFloat(_masterVolume, _maxVolume);
        }
    }
}
