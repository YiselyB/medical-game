using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour, IInteractable
{
    GameObject interactor;
    Interactor interactorScript;

    public void Start()
    {
        
    }

    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
        interactor = GameObject.Find("Interactor");
        interactorScript = interactor.GetComponent<Interactor>();
        interactorScript.AddHealth(10);
    }

    
}
