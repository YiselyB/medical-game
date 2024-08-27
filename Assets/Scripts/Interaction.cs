using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour, IInteractable
{
    GameObject interactor;
    Interactor interactorScript;
    bool interact1 = false, interact2 = false;
    public int interactNum = -1;

    public void Start()
    {
        //make sure interactions are set to false
        interact1 = false;
        interact2 = false;
    }

    public void Interact()
    {
        Debug.Log(interactNum);
        interactor = GameObject.Find("Scripts");
        //interactorScript = interactor.GetComponent<Interactor>();
        //interactorScript.AddHealth(10);

        switch (interactNum)
        {
            case 1://First interaction
                //first check if interaction has happened before
                if (!interact1)
                {
                    //If no interaction has happened before then do the interaction

                    //'scan' player
                    //move player
                    //turn off sparkles
                    //turn on next interaction sparkles

                    interact2 = false; //ensure next interaction is available
                    interact1 = true;
                }
                break;
            case 2://second interation
                //first check if interaction has happened before
                if (!interact2)
                {
                    //If no interaction has happened before then do the interaction

                    //pop up menu of 3 services pops up
                    //sparkles turn off

                    interact2 = true;
                }
                break;
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
    }

    public void healPatient(int num)
    {
        if(num == 1) {//mono service
            interactorScript = interactor.GetComponent<Interactor>();
            interactorScript.AddHealth(40);
        }
        else if(num == 2) {//stereo service
            interactorScript = interactor.GetComponent<Interactor>();
            interactorScript.AddHealth(65);
        }
        else if(num == 3) {//surround service
            interactorScript = interactor.GetComponent<Interactor>();
            interactorScript.AddHealth(90);
        }
    }
}
