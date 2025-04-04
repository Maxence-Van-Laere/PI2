using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public GameObject panelCoupable;
    public GameObject panelAccueil;
    public GameObject panelContenu;

    public GameObject[] contenus; // Contiendra les 5 contenus (Alexandre, Christophe, etc.)
    private GameObject contenuActuel;

    void Start()
    {
        // Assurer que seul le Panel Coupable est actif au début
        panelCoupable.SetActive(true);
        panelAccueil.SetActive(false);
        panelContenu.SetActive(false);

        // Désactiver tous les contenus pour éviter les erreurs d'affichage
        foreach (GameObject contenu in contenus)
        {
            contenu.SetActive(false);
        }
    }

    // Appelée quand on appuie sur "Continuer" dans Panel_Coupable
    public void AfficherAccueil()
    {
        panelCoupable.SetActive(false);
        panelAccueil.SetActive(true);
    }

    // Appelée quand on clique sur un des 5 boutons du Panel_Accueil
    public void AfficherContenu(int index)
    {
        panelAccueil.SetActive(false);
        panelContenu.SetActive(true);

        // Désactiver l'ancien contenu affiché s'il y en avait un
        if (contenuActuel != null)
        {
            contenuActuel.SetActive(false);
        }

        // Activer le contenu correspondant au bouton cliqué
        contenuActuel = contenus[index];
        contenuActuel.SetActive(true);
    }

    // Bouton retour dans le panel Contenu
    public void RetourAccueil()
    {
        panelContenu.SetActive(false);
        panelAccueil.SetActive(true);

        // Désactiver le contenu actuellement affiché
        if (contenuActuel != null)
        {
            contenuActuel.SetActive(false);
        }
    }
}
