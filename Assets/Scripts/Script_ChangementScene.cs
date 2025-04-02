using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_ChangementScene : MonoBehaviour
{
    public string sceneName;
    public Button changeSceneButton;

    void Start()
    {
        changeSceneButton.onClick.AddListener(ChangeScene);
    }

    // Méthode appelée lorsque le bouton est cliqué
    public void ChangeScene()
    {
        // Charger la scène spécifiée
        SceneManager.LoadScene(sceneName);
    }
}
