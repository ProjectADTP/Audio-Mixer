using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;

public class PanelSoundSettings : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;
    [SerializeField] private Slider _soundSlider;
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _uiSlider;

    private int _ratio = 20;
    private Dictionary<Slider, UnityAction<float>> _sliderHandlers;

    private void Awake()
    {
        _sliderHandlers = new Dictionary<Slider, UnityAction<float>>
        {
            { _soundSlider, volume => SetMixerVolume("SoundVolume", volume) },
            { _musicSlider, volume => SetMixerVolume("MusicVolume", volume) },
            { _uiSlider, volume => SetMixerVolume("UIVolume", volume) }
        };
    }

    private void OnEnable()
    {
        foreach (var slider in _sliderHandlers)
        {
            slider.Key.onValueChanged.AddListener(slider.Value);
        }
    }

    private void OnDisable()
    {
        foreach (var slider in _sliderHandlers)
        {
            slider.Key.onValueChanged.RemoveListener(slider.Value);
        }
    }

    private void SetMixerVolume(string parameter, float volume)
    {
        _audioMixer.audioMixer.SetFloat(parameter, ConvertToDecibels(volume));
    }

    private float ConvertToDecibels(float volume)
    {
        return Mathf.Log10(volume) * _ratio;
    }
}
