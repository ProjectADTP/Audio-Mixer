using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSlider : VolumeSliderController
{
    protected override string GetMixerParameter() => "SoundVolume";
}
