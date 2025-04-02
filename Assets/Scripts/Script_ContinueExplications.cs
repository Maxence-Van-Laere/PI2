using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_ContinueExplications : MonoBehaviour
{
    public Button buttonContinuer;
    public Button buttonCommencer;
    public Image myTextA;
    public Image myTextB;

    void Start()
    {
        buttonContinuer.onClick.AddListener(OnButtonContinueClick);
    }

    void OnButtonContinueClick()
    {
        myTextA.gameObject.SetActive(false);  // le texteA se cache
        myTextB.gameObject.SetActive(true);  // le texteB s'affiche
        buttonContinuer.gameObject.SetActive(false);  // le bouton continuer A se cache
        buttonCommencer.gameObject.SetActive(true);
    }
}