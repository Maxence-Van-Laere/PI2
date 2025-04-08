using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_BossDiscussion : MonoBehaviour
{
    public Button buttonStart;
    public Button buttonContinue;
    public Button buttonStop;
    public Image myText;

    void Start()
    {
        buttonStart.onClick.AddListener(OnButtonStartClick);
    }

    void OnButtonStartClick()
    {
        myText.gameObject.SetActive(true);  // le texte1 s'affiche
        buttonStart.gameObject.SetActive(false);  // le bouton commencer se cache
        buttonContinue.gameObject.SetActive(true);  // le bouton pour continuer s'affiche
        buttonStop.gameObject.SetActive(true);  // le bouton pour finir s'affiche
    }
}