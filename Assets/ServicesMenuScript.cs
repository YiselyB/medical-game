using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicesMenuScript : MonoBehaviour
{
    public AudioSource audio;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;

    public void monoSoundbutton ()
    {
        audio.Play();
    }
    public void stereoSoundButton()
    {
        audio2.Play();
    }
    public void surroundSoundButton()
    {
        audio3.Play();
    }
    public void backButton()
    {
        audio4.Play();
    }
}
