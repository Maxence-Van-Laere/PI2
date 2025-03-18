using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;


public class ObjectOpen : MonoBehaviour
{
    [Header("Configuration Ouverture")]
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private string nomTriggerOpen;
    [SerializeField] private string nomTriggerClose;
    [SerializeField] private KeyCode actionKey = KeyCode.E;

    private bool estOuvert = false;
    private bool isPlayerInRange = false;

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(actionKey))
        {
            ToggleDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    private void ToggleDoor()
    {
        if (doorAnimator != null)
        {
            if (estOuvert)
            {
                doorAnimator.SetTrigger(nomTriggerClose);
            }
            else
            {
                doorAnimator.SetTrigger(nomTriggerOpen);
            }
            estOuvert = !estOuvert;
        }
    }
}
