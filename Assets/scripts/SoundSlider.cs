using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSlider : VolumeSlider
{
    protected override string MixerParameter() => "SoundVolume";
}
