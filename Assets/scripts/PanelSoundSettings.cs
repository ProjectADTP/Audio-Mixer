using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PanelSoundSettings : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;

    [SerializeField] private Slider _soundSlider;
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _uiSlider;

    private int _ratio = 20;

    private void OnEnable()
    {
        _soundSlider.onValueChanged.AddListener(SoundChange);
        _musicSlider.onValueChanged.AddListener(MusicChange);
        _uiSlider.onValueChanged.AddListener(UISoundChange);
    }

    private void OnDisable()
    {
        _soundSlider.onValueChanged.RemoveListener(SoundChange);
        _musicSlider.onValueChanged.RemoveListener(MusicChange);
        _uiSlider.onValueChanged.RemoveListener(UISoundChange);
    }

    private void SoundChange(float volume)
    {
        _audioMixer.audioMixer.SetFloat("SoundVolume", ConvertToDecibels(volume));
    }

    private void MusicChange(float volume)
    {
        _audioMixer.audioMixer.SetFloat("MusicVolume", ConvertToDecibels(volume));
    }

    private void UISoundChange(float volume)
    {
        _audioMixer.audioMixer.SetFloat("UIVolume", ConvertToDecibels(volume));
    }

    private float ConvertToDecibels(float volume)
    {
        return Mathf.Log10(volume) * _ratio;
    }
}
