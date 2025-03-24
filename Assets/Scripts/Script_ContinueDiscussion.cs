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
    public string triggerStart;
    public string triggerEnd;
    public GameObject chaise;
    public GameObject perso;
    public float rotationDuration = 1.0f;
    public float rotationAngle = 90.0f;

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
        animator.ResetTrigger(triggerStart);
        StartCoroutine(RotateObject(rotationAngle, chaise));
        StartCoroutine(RotateObject(rotationAngle, perso));
    }

    IEnumerator RotateObject(float angle, GameObject objectToRotate)
    {
        float elapsedTime = 0f;
        Vector3 startRotation = objectToRotate.transform.eulerAngles;
        Vector3 endRotation = startRotation + new Vector3(0, -angle, 0);

        while (elapsedTime < rotationDuration)
        {
            objectToRotate.transform.eulerAngles = Vector3.Lerp(startRotation, endRotation, elapsedTime / rotationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Assurez-vous que l'objet atteint exactement la rotation finale
        objectToRotate.transform.eulerAngles = endRotation;
    }
}