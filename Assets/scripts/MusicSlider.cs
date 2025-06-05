using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSlider : VolumeSlider
{
    protected override string MixerParameter() => "MusicVolume";
}
