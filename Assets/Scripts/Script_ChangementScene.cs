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

    // M�thode appel�e lorsque le bouton est cliqu�
    public void ChangeScene()
    {
        // Charger la sc�ne sp�cifi�e
        SceneManager.LoadScene(sceneName);
    }
}
