using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISlider : VolumeSliderController
{
    protected override string GetMixerParameter() => "UIVolume";
}
