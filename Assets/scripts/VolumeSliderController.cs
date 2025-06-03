using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public abstract class VolumeSliderController : MonoBehaviour
{
    [SerializeField] protected AudioMixerGroup _audioMixer;
    [SerializeField] protected Slider _slider;
    
    protected int _ratio = 20;

    protected abstract string GetMixerParameter();

    protected virtual void OnEnable()
    {
        _slider.onValueChanged.AddListener(HandleSliderChanged);
    }

    protected virtual void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(HandleSliderChanged);
    }

    private void HandleSliderChanged(float volume)
    {
        _audioMixer.audioMixer.SetFloat(GetMixerParameter(), ConvertToDecibels(volume));
    }

    protected float ConvertToDecibels(float volume)
    {
        return Mathf.Log10(volume) * _ratio;
    }
}
