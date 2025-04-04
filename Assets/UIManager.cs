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
        // Assurer que seul le Panel Coupable est actif au d�but
        panelCoupable.SetActive(true);
        panelAccueil.SetActive(false);
        panelContenu.SetActive(false);

        // D�sactiver tous les contenus pour �viter les erreurs d'affichage
        foreach (GameObject contenu in contenus)
        {
            contenu.SetActive(false);
        }
    }

    // Appel�e quand on appuie sur "Continuer" dans Panel_Coupable
    public void AfficherAccueil()
    {
        panelCoupable.SetActive(false);
        panelAccueil.SetActive(true);
    }

    // Appel�e quand on clique sur un des 5 boutons du Panel_Accueil
    public void AfficherContenu(int index)
    {
        panelAccueil.SetActive(false);
        panelContenu.SetActive(true);

        // D�sactiver l'ancien contenu affich� s'il y en avait un
        if (contenuActuel != null)
        {
            contenuActuel.SetActive(false);
        }

        // Activer le contenu correspondant au bouton cliqu�
        contenuActuel = contenus[index];
        contenuActuel.SetActive(true);
    }

    // Bouton retour dans le panel Contenu
    public void RetourAccueil()
    {
        panelContenu.SetActive(false);
        panelAccueil.SetActive(true);

        // D�sactiver le contenu actuellement affich�
        if (contenuActuel != null)
        {
            contenuActuel.SetActive(false);
        }
    }
}
