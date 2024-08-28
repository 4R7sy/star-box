using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar cenas

public class TitleScreenManager : MonoBehaviour
{
    // Refer�ncias aos bot�es
    public UnityEngine.UI.Button startButton;
    public UnityEngine.UI.Button optionsButton;
    public UnityEngine.UI.Button quitButton;

    void Start()
    {
        // Certifique-se de que os bot�es estejam atribu�dos
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
        else
        {
            Debug.LogError("StartButton n�o est� atribu�do no Inspector.");
        }

        if (optionsButton != null)
        {
            optionsButton.onClick.AddListener(OpenOptions);
        }
        else
        {
            Debug.LogError("OptionsButton n�o est� atribu�do no Inspector.");
        }

        if (quitButton != null)
        {
            quitButton.onClick.AddListener(QuitGame);
        }
        else
        {
            Debug.LogError("QuitButton n�o est� atribu�do no Inspector.");
        }
    }

    // M�todo para iniciar o jogo
    void StartGame()
    {
        // Substitua "GameScene" pelo nome da sua cena de jogo
        SceneManager.LoadScene("GameScene");
    }

    // M�todo para abrir a tela de op��es
    void OpenOptions()
    {
        // Substitua "OptionsScreen" pelo nome da sua cena de op��es
        SceneManager.LoadScene("OptionsScreen");
    }

    // M�todo para sair do jogo
    void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Para o editor
#else
        Application.Quit(); // Para builds
#endif
    }
}
