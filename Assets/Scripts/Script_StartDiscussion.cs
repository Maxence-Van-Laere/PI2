using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_StartDiscussion : MonoBehaviour
{
    public Button buttonStart;
    public Button buttonContinue;
    public Button buttonEnd;
    public Image myText;
    public Animator animator;
    public string triggerStart;

    void Start()
    {
        buttonStart.onClick.AddListener(OnButtonStartClick);
    }

    void OnButtonStartClick()
    {
        myText.gameObject.SetActive(true);  // le texte1 s'affiche
        buttonStart.gameObject.SetActive(false);  // le bouton commencer se cache
        buttonContinue.gameObject.SetActive(true);  // le bouton pour continuer s'affiche
        buttonEnd.gameObject.SetActive(true);  // le bouton pour finir s'affiche
        animator.SetTrigger(triggerStart);  // l'animation commence
    }
}