using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour, IInteractable
{
    public Image healthBar;
    public float healthAmount = 10f;

    public void Start()
    {
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Interact()
    {
        //Debug.Log(Random.Range(0, 100));
        AddHealth(10);
    }

    public void AddHealth(float healAmount)
    {
        healthAmount += healAmount;
        if (healthAmount > 100) {  healthAmount = 100; }
        healthBar.fillAmount = healthAmount / 100f;
    }
}
