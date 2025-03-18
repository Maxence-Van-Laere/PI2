using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_EndDiscussion : MonoBehaviour
{
    public Button buttonEnd;
    public Button buttonContinue3;
    public Image myText;
    public Animator animator;
    public string triggerEnd;

    void Start()
    {
        buttonContinue3.onClick.AddListener(OnButton3Click);
        buttonEnd.onClick.AddListener(OnButtonEndClick);
    }

    void OnButton3Click()
    {
        buttonContinue3.gameObject.SetActive(false);
    }

    void OnButtonEndClick()
    {
        myText.gameObject.SetActive(false);
        buttonContinue3.gameObject.SetActive(false);
        buttonEnd.gameObject.SetActive(false);
        animator.SetTrigger(triggerEnd);
    }
}