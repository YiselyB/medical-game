using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;

    //Health
    public Image healthBar;
    public float healthAmount = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        healthBar.fillAmount = healthAmount / 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E");
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }

    public void ButtonPress()
    {
        Debug.Log("Button pressed");
        Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        {
            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
            {
                interactObj.Interact();
            }
        }
    }

    public void AddHealth(float healAmount)
    {
        healthAmount += healAmount;
        if (healthAmount > 100) { healthAmount = 100; }
        healthBar.fillAmount = healthAmount / 100f;
    }
}
