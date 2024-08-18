using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class Interaction : MonoBehaviour, IInteractable
{
    GameObject interactor;
    Interactor interactorScript;
    public int interactNum = -1;

    public void Start()
    {
        
    }

    public void Interact()
    {
        if(interactNum == 10)
        {
            Application.OpenURL("https://www.youtube.com/@BoominMediaDotBiz");
        }
        Debug.Log(interactNum);
        interactor = GameObject.Find("Scripts");
        interactorScript = interactor.GetComponent<Interactor>();
        interactorScript.AddHealth(10);
    }

    
}
