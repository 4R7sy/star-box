using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    public int width = 240;  // Largura da resolução desejada
    public int height = 160; // Altura da resolução desejada

    void Start()
    {
        // Força a resolução no modo janela e tela cheia
        Screen.SetResolution(width, height, Screen.fullScreen);
    }

    void Update()
    {
        // Alterna entre tela cheia e janela quando a tecla F11 é pressionada
        if (Input.GetKeyDown(KeyCode.F11))
        {
            bool isFullScreen = !Screen.fullScreen;
            Screen.SetResolution(width, height, isFullScreen);
        }
    }
}
