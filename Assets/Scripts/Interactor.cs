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
    public float InteractRange, fadeSpeed;

    //Health
    public Image healthBar;
    public float healthAmount = 10f;

    private bool interact1, interact2, fadeOut, fadeIn; 
    public Canvas popuptxt, popupmenu;
    public GameObject patient;
    public ParticleSystem interactable1, interactable2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        healthBar.fillAmount = healthAmount / 100f;

        interact1 = false;
        interact2 = true;
        interactable1.Play();
        interactable2.Stop();


        //make sure pop-up menu is not enabled
        popupmenu.enabled = false;
        //make sure pop-up text is not enabled
        popuptxt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E" + interact1 + " " + interact2);
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

    public void InteractObj(int n)
    {
        if (n == 1)
        {
            interact1 = true;
            interact2 = false;
        }
        else if (n == 2)
        {
            interact2 = true;
        }
    }

    public void ScanPlayer()
    {
        popuptxt.enabled = true;
        Invoke("HidePopupText", 5f);
    }

    public void HidePopupText() { popuptxt.enabled = false; }

    public void OptionMenu(bool onoff) { popupmenu.enabled = onoff; }

    public bool Interact1() { return interact1; }
    public bool Interact2() { return interact2; }

    public void ParticleManager(int n)
    {
        if (n == 1) { //turn off first machine particle, and turn on second
            interactable1.Stop();
            interactable2.Play();
        }
        else if (n == 2) { //turn off all particles
            interactable2.Stop();
        }
    }
    
    public void MovePatient()
    {
        Invoke("StartFadeOut", 1f);

        Invoke("TransformPatient", 6f);

        Invoke("StartFadeIn", 7f);
    }

    public void TransformPatient()
    {
        //moves patient to the right
        patient.transform.position += Vector3.right * 6.8f;

    }

    public void StartFadeOut() {
        //fades out patient
        StartCoroutine(FadeOutObj());
    }

    public void StartFadeIn() {
        //fades out patient
        StartCoroutine(FadeInObj());
    }

    public IEnumerator FadeOutObj()
    {
        //Fades out patient
        while (patient.GetComponent<Renderer>().material.color.a > 0)
        {
            Debug.Log("FadeOut");
            Color objectColor = patient.GetComponent<Renderer>().material.color;
            float fadeAmt = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmt);
            patient.GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }
    public IEnumerator FadeInObj()
    {
        //Fades in patient
        while (patient.GetComponent<Renderer>().material.color.a < 1)
        {
            Debug.Log("FadeIn");
            Color objectColor = patient.GetComponent<Renderer>().material.color;
            float fadeAmt = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmt);
            patient.GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }

    public void healPatient(int num)
    {
        if (num == 1)
        {//mono service
            AddHealth(40);
        }
        else if (num == 2)
        {//stereo service
            AddHealth(65);
        }
        else if (num == 3)
        {//surround service
            AddHealth(90);
        }
        OptionMenu(false);
    }
}
