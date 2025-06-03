using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSlider : VolumeSliderController
{
    protected override string GetMixerParameter() => "MusicVolume";
}
