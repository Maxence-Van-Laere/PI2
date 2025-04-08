using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_BossContinueDiscussion : MonoBehaviour
{
    public Button buttonContinue;
    public Button buttonStop;
    public Image myTextA;
    public Image myTextB;
    public Button buttonAlexandre;
    public Button buttonBenoit;
    public Button buttonChristophe;
    public Button buttonMarion;
    public Button buttonSophie;

    void Start()
    {
        buttonContinue.onClick.AddListener(OnButtonContinueClick);
        buttonStop.onClick.AddListener(OnButtonEndClick);
    }

    void OnButtonContinueClick()
    {
        myTextA.gameObject.SetActive(false);  // le texteA se cache
        myTextB.gameObject.SetActive(true);  // le texteB s'affiche
        buttonContinue.gameObject.SetActive(false);  // le bouton continuer A se cache
        buttonStop.gameObject.SetActive(false);
        buttonAlexandre.gameObject.SetActive(true);
        buttonBenoit.gameObject.SetActive(true);
        buttonChristophe.gameObject.SetActive(true);
        buttonMarion.gameObject.SetActive(true);
        buttonSophie.gameObject.SetActive(true);
    }

    void OnButtonEndClick()
    {
        myTextA.gameObject.SetActive(false);  // le texteA se cache
        buttonContinue.gameObject.SetActive(false);  // le bouton continuer A se cache
        buttonStop.gameObject.SetActive(false);  // le bouton pour finir se cache
    }
}