using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject canvasNote;  // Référence au Canvas contenant la note
    private bool isCanvasVisible = false; // Variable pour savoir si le canvas est visible
    private InputDevice primaryButtonDevice; // Référence au contrôleur du bouton primaire
    private bool isPrimaryButtonPressed = false; // Si le bouton primaire est appuyé

    void Start()
    {
        // Assigner le contrôleur du bouton primaire (cela pourrait être différent selon ton setup VR)
        var inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, inputDevices); // Utilise le contrôle de la main gauche, ou remplace par XRNode.RightHand si nécessaire
        primaryButtonDevice = inputDevices[0];

        // Assure-toi que le canvas est initialement masqué
        canvasNote.SetActive(false);
    }

    void Update()
    {
        // Vérifier si le bouton primaire est appuyé
        if (primaryButtonDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonPressed) && primaryButtonPressed && !isPrimaryButtonPressed)
        {
            // Inverser la visibilité du canvas
            isCanvasVisible = !isCanvasVisible;
            canvasNote.SetActive(isCanvasVisible);
            isPrimaryButtonPressed = true; // Marque le bouton comme étant appuyé pour éviter de traiter la même pression plusieurs fois
        }
        else if (!primaryButtonPressed)
        {
            // Réinitialiser lorsque le bouton primaire n'est plus appuyé
            isPrimaryButtonPressed = false;
        }
    }
}

