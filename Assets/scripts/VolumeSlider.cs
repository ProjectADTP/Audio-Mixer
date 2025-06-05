using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public abstract class VolumeSlider : MonoBehaviour
{
    [SerializeField] protected AudioMixerGroup AudioMixer;
    [SerializeField] protected Slider Slider;
    
    protected int _ratio = 20;

    protected virtual void OnEnable()
    {
        Slider.onValueChanged.AddListener(HandleSliderChanged);
    }

    protected virtual void OnDisable()
    {
        Slider.onValueChanged.RemoveListener(HandleSliderChanged);
    }

    private void HandleSliderChanged(float volume)
    {
        AudioMixer.audioMixer.SetFloat(MixerParameter(), ConvertToDecibels(volume));
    }

    protected float ConvertToDecibels(float volume)
    {
        return Mathf.Log10(volume) * _ratio;
    }

    protected abstract string MixerParameter();
}
