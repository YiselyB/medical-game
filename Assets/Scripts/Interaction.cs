using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour, IInteractable
{
    GameObject interactor;
    Interactor interactorScript;

    
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
        Debug.Log("Interacted with the prop");

        
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

