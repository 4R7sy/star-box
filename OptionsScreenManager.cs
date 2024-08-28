using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar cenas

public class OptionsScreenManager : MonoBehaviour
{
    // Referência ao botão de voltar
    public UnityEngine.UI.Button backButton;

    void Start()
    {
        // Certifique-se de que o botão esteja atribuído
        if (backButton != null)
        {
            backButton.onClick.AddListener(BackToTitleScreen);
        }
        else
        {
            Debug.LogError("BackButton não está atribuído no Inspector.");
        }
    }

    // Método para voltar para a tela de título
    void BackToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen"); // Substitua "TitleScreen" pelo nome da sua cena de título
    }
}
