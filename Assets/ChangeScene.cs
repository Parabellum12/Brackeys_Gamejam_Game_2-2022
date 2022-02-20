using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Button ResButton;
    public string nextScene;

    void Start()
    {
        Button button = ResButton.GetComponent<Button>();
        button.onClick.AddListener(ChangeToScene);
    }

    void ChangeToScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
