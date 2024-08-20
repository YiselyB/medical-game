using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour, IInteractable
{
    GameObject interactor;
    Interactor interactorScript;
    public int interactNum = -1;
    public GameObject servicesPanel;

    private bool isPanelActive = false;


    public void Start()
    {

        if (interactor == null)
        {
            interactor = GameObject.Find("Interactor");
            interactorScript = interactor.GetComponent<Interactor>();
        }

        if (servicesPanel != null)
        {
            servicesPanel.SetActive(false);
        }
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

        if (servicesPanel != null)
        {
            isPanelActive = !isPanelActive;
            servicesPanel.SetActive(isPanelActive);
        }
    }

    void Update()
    {
        if (isPanelActive && Input.GetKeyDown(KeyCode.E))
        {
            servicesPanel.SetActive(false);
            isPanelActive = false;
        }
    }


}
