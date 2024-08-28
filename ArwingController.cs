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
    AudioSource Rotação;

    [SerializeField]float ControleVelocidade = 10f;
    [SerializeField]float ControleRotaçãoDir = 10f;
    [SerializeField]float ControleRotaçãoEsq = 10f;
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
        MovimentaçãoNave();
        Audios();
    }

    void MovimentaçãoNave()
    {
        float Z = Input.GetAxis("Horizontal") * Time.deltaTime * ControleVelocidade;
        float Y = Input.GetAxis("Vertical") * Time.deltaTime * ControleVelocidade;
        float VelocidadeAuto = 0.2f * Time.deltaTime * ControleAuto;
        float RotaçãoArwingDir = 10f * Time.deltaTime * ControleRotaçãoDir;
        float RotaçãoArwingEsq = -10f * Time.deltaTime * ControleRotaçãoEsq;
        float SprintArwing = 10f * Time.deltaTime * ControleSprint;
        float DevagarArwing = 10f * Time.deltaTime * ControleDevagar;

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, RotaçãoArwingDir, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, RotaçãoArwingEsq, 0);
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
            if(Rotação.isPlaying)
            {
                Rotação.Play();
                Voo.Stop();
            }
        }
        else
        {
            Voo.Play();
            Rotação.Stop();
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (Rotação.isPlaying)
            {
                Rotação.Play();
                Voo.Stop();
            }
        }
        else
        {
            Voo.Play();
            Rotação.Stop();
        }
    }
}
