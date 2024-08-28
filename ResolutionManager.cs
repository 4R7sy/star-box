using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    public int width = 240;  // Largura da resolu��o desejada
    public int height = 160; // Altura da resolu��o desejada

    void Start()
    {
        // For�a a resolu��o no modo janela e tela cheia
        Screen.SetResolution(width, height, Screen.fullScreen);
    }

    void Update()
    {
        // Alterna entre tela cheia e janela quando a tecla F11 � pressionada
        if (Input.GetKeyDown(KeyCode.F11))
        {
            bool isFullScreen = !Screen.fullScreen;
            Screen.SetResolution(width, height, isFullScreen);
        }
    }
}
