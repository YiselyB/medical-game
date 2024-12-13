using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static audioManager instance;
    public AudioSource musicSource; 

    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
            if (musicSource != null && !musicSource.isPlaying)
            {
                musicSource.Play();
            }
        }
        else
        {
          
            Destroy(gameObject);
        }
    }
}
