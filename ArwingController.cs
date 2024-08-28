using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArwingController : MonoBehaviour
{
    [SerializeField]
    AudioSource Voo;

    [SerializeField]
    AudioSource Dash;

    [SerializeField]
    AudioSource Rota��o;

    [SerializeField]float ControleVelocidade = 10f;
    [SerializeField]float ControleRota��oDir = 10f;
    [SerializeField]float ControleRota��oEsq = 10f;
    [SerializeField] float ControleSprint = 10f;
    [SerializeField] float ControleDevagar = 10f;
    [SerializeField] float ControleAuto = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Controle a nave!!");
    }

    // Update is called once per frame
    void Update()
    {
        Movimenta��oNave();
        Audios();
    }

    void Movimenta��oNave()
    {
        float Z = Input.GetAxis("Horizontal") * Time.deltaTime * ControleVelocidade;
        float Y = Input.GetAxis("Vertical") * Time.deltaTime * ControleVelocidade;
        float VelocidadeAuto = 0.2f * Time.deltaTime * ControleAuto;
        float Rota��oArwingDir = 10f * Time.deltaTime * ControleRota��oDir;
        float Rota��oArwingEsq = -10f * Time.deltaTime * ControleRota��oEsq;
        float SprintArwing = 10f * Time.deltaTime * ControleSprint;
        float DevagarArwing = 10f * Time.deltaTime * ControleDevagar;

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, Rota��oArwingDir, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, Rota��oArwingEsq, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Z, Y, SprintArwing);
        }
        else
        {
            
        }

        if(Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Z, Y, DevagarArwing);
        }
        else
        {

        }

        transform.Translate(Z, Y, VelocidadeAuto);
    }

    void Audios()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            if(!Dash.isPlaying)
            {
                Dash.Play();
                Voo.Stop();
            }
        }
        else
        {
            Voo.Play();
            Dash.Stop();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            if(Rota��o.isPlaying)
            {
                Rota��o.Play();
                Voo.Stop();
            }
        }
        else
        {
            Voo.Play();
            Rota��o.Stop();
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (Rota��o.isPlaying)
            {
                Rota��o.Play();
                Voo.Stop();
            }
        }
        else
        {
            Voo.Play();
            Rota��o.Stop();
        }
    }
}
