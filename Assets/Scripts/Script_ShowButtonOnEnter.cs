using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_ShowButtonOnEnter : MonoBehaviour
{
    public Button myButton; // Le bouton � afficher

    void OnTriggerEnter(Collider other)
    {
        // V�rifiez si l'objet qui entre dans le collider est le joueur (XR Device Simulator)
        if (other.CompareTag("MainCamera"))
        {
            myButton.gameObject.SetActive(true); // Affiche le bouton
        }
    }

    void OnTriggerExit(Collider other)
    {
        // V�rifiez si l'objet qui sort du collider est le joueur
        if (other.CompareTag("MainCamera"))
        {
            myButton.gameObject.SetActive(false); // Cache le bouton
        }
    }
}