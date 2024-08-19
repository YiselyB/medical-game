using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        switch (interactNum)
        {
            case 10://Youtbe URL
                Application.OpenURL("https://www.youtube.com/@BoominMediaDotBiz");
                break;
            case 11://LinkedIn URL
                Application.OpenURL("https://www.linkedin.com/company/boomin-media/");
                break;
            case 12://Facebook URL
                Application.OpenURL("https://www.facebook.com/people/Boomin-Media/61557447059293/");
                break;
            case 13://Instagram URL
                Application.OpenURL("https://www.instagram.com/boominmediadotbiz/");
                break;
            default:
                break;
        }
        Debug.Log(interactNum);
        interactor = GameObject.Find("Scripts");
        interactorScript = interactor.GetComponent<Interactor>();
        interactorScript.AddHealth(10);
    }

    
}
