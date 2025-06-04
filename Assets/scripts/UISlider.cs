using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISlider : VolumeSlider
{
    protected override string SetMixerParameter() => "UIVolume";
}
