using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar cenas

public class TitleScreenManager : MonoBehaviour
{
    // Referências aos botões
    public UnityEngine.UI.Button startButton;
    public UnityEngine.UI.Button optionsButton;
    public UnityEngine.UI.Button quitButton;

    void Start()
    {
        // Certifique-se de que os botões estejam atribuídos
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
        else
        {
            Debug.LogError("StartButton não está atribuído no Inspector.");
        }

        if (optionsButton != null)
        {
            optionsButton.onClick.AddListener(OpenOptions);
        }
        else
        {
            Debug.LogError("OptionsButton não está atribuído no Inspector.");
        }

        if (quitButton != null)
        {
            quitButton.onClick.AddListener(QuitGame);
        }
        else
        {
            Debug.LogError("QuitButton não está atribuído no Inspector.");
        }
    }

    // Método para iniciar o jogo
    void StartGame()
    {
        // Substitua "GameScene" pelo nome da sua cena de jogo
        SceneManager.LoadScene("GameScene");
    }

    // Método para abrir a tela de opções
    void OpenOptions()
    {
        // Substitua "OptionsScreen" pelo nome da sua cena de opções
        SceneManager.LoadScene("OptionsScreen");
    }

    // Método para sair do jogo
    void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Para o editor
#else
        Application.Quit(); // Para builds
#endif
    }
}
