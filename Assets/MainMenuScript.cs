using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour

  
{
    public AudioSource audio;
    public AudioSource audio2;


    public void playButton()
    {
        audio.Play();
    }
    public void servicesButton() {
        audio2.Play();

    }


}
