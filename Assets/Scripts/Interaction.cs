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
        Debug.Log(interactNum);
        interactor = GameObject.Find("Scripts");
        interactorScript = interactor.GetComponent<Interactor>();
        switch (interactNum)
        {
            case 1://First interaction
                //first check if interaction has happened before
                if (!interactorScript.Interact1())
                {//If no interaction has happened before then do the interaction
                    //'scan' player
                    interactorScript.ScanPlayer();
                    //move patient
                    interactorScript.TransformPatient();
                    //turn off sparkles obj sparkles and turn on next
                    interactorScript.ParticleManager(1);

                    interactorScript.InteractObj(1);
                }
                break;
            case 2://second interation
                //first check if interaction has happened before
                if (!interactorScript.Interact2())
                {//If no interaction has happened before then do the interaction
                    //pop up menu of 3 services pops up
                    interactorScript.OptionMenu(true);
                    //sparkles turn off
                    interactorScript.ParticleManager(2);

                    interactorScript.InteractObj(2);
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
}
