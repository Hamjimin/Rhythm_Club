using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource Bgm;
    public AudioSource Button;
    public AudioSource Start;
    public AudioSource Jump;
    public AudioSource Attack;
    public Slider BGMslider;
    public Slider SFXslider;
    public void SetBgmVolume()
    {
        Bgm.volume = BGMslider.value * 0.1f;
    }
    public void SetSfxVolume()
    {
        Button.volume = SFXslider.value * 0.1f;
        Jump.volume = SFXslider.value * 0.1f;
        Start.volume = SFXslider.value * 0.1f;
        Attack.volume = SFXslider.value * 0.1f;
    }
}
