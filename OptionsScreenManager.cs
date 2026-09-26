using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsScreenManager : MonoBehaviour
{
    public UnityEngine.UI.Button backButton;

    void Start()
    {
        if (backButton != null)
        {
            backButton.onClick.AddListener(BackToTitleScreen);
        }
        else
        {
            Debug.LogError("BackButton não está atribuído no Inspector.");
        }
    }

  
    void BackToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
