using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_ContinueDiscussion : MonoBehaviour
{
    public Button buttonContinueA;
    public Button buttonContinueB;
    public Button buttonEnd;
    public Image myTextA;
    public Image myTextB;
    public Animator animator;
    public string triggerEnd;

    void Start()
    {
        buttonContinueA.onClick.AddListener(OnButtonContinueClick);
        buttonEnd.onClick.AddListener(OnButtonEndClick);
    }

    void OnButtonContinueClick()
    {
        myTextA.gameObject.SetActive(false);  // le texteA se cache
        myTextB.gameObject.SetActive(true);  // le texteB s'affiche
        buttonContinueA.gameObject.SetActive(false);  // le bouton continuer A se cache
        buttonContinueB.gameObject.SetActive(true);  // le bouton continuer B s'affiche
    }

    void OnButtonEndClick()
    {
        myTextA.gameObject.SetActive(false);  // le texteA se cache
        buttonContinueA.gameObject.SetActive(false);  // le bouton continuer A se cache
        buttonEnd.gameObject.SetActive(false);  // le bouton pour finir se cache
        animator.SetTrigger(triggerEnd);  // l'annimation s'arrete
    }
}