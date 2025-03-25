using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_EndDiscussion : MonoBehaviour
{
    public Button buttonEnd;
    public Button buttonStop;
    public Image myText;
    public Animator animator;
    public string triggerStart;
    public string triggerEnd;
    public GameObject chaise;
    public GameObject perso;
    public float rotationDuration = 1.0f;
    public float rotationAngle = 90.0f;

    void Start()
    {
        buttonEnd.onClick.AddListener(OnButtonEndClick);
    }

    void OnButtonEndClick()
    {
        myText.gameObject.SetActive(false);
        buttonEnd.gameObject.SetActive(false);
        buttonStop.gameObject.SetActive(false);
        animator.SetTrigger(triggerEnd);
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