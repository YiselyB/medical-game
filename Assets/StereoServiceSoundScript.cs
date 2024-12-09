using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereoServiceSoundScript : MonoBehaviour
{
    public AudioSource audio;

    public void backButton()
    {
        audio.Play();
    }
}
