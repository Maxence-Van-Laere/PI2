using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject canvasNote;  // R�f�rence au Canvas contenant la note
    private bool isCanvasVisible = false; // Variable pour savoir si le canvas est visible
    private InputDevice primaryButtonDevice; // R�f�rence au contr�leur du bouton primaire
    private bool isPrimaryButtonPressed = false; // Si le bouton primaire est appuy�

    void Start()
    {
        // Assigner le contr�leur du bouton primaire (cela pourrait �tre diff�rent selon ton setup VR)
        var inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, inputDevices); // Utilise le contr�le de la main gauche, ou remplace par XRNode.RightHand si n�cessaire
        primaryButtonDevice = inputDevices[0];

        // Assure-toi que le canvas est initialement masqu�
        canvasNote.SetActive(false);
    }

    void Update()
    {
        // V�rifier si le bouton primaire est appuy�
        if (primaryButtonDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonPressed) && primaryButtonPressed && !isPrimaryButtonPressed)
        {
            // Inverser la visibilit� du canvas
            isCanvasVisible = !isCanvasVisible;
            canvasNote.SetActive(isCanvasVisible);
            isPrimaryButtonPressed = true; // Marque le bouton comme �tant appuy� pour �viter de traiter la m�me pression plusieurs fois
        }
        else if (!primaryButtonPressed)
        {
            // R�initialiser lorsque le bouton primaire n'est plus appuy�
            isPrimaryButtonPressed = false;
        }
    }
}

