using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar cenas

public class OptionsScreenManager : MonoBehaviour
{
    // Refer�ncia ao bot�o de voltar
    public UnityEngine.UI.Button backButton;

    void Start()
    {
        // Certifique-se de que o bot�o esteja atribu�do
        if (backButton != null)
        {
            backButton.onClick.AddListener(BackToTitleScreen);
        }
        else
        {
            Debug.LogError("BackButton n�o est� atribu�do no Inspector.");
        }
    }

    // M�todo para voltar para a tela de t�tulo
    void BackToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen"); // Substitua "TitleScreen" pelo nome da sua cena de t�tulo
    }
}
