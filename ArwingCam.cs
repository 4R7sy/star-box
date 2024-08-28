using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float ControleRotaçãoDir = 10f;
    [SerializeField] float ControleRotaçãoEsq = 10f;
    [SerializeField] float CamControleSprint = 10f;
    [SerializeField] float CamControleAuto = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamSeguir();
    }

    void CamSeguir()
    {
        float RotaçãoCamDir = 10f * Time.deltaTime * ControleRotaçãoDir;
        float RotaçãoCamEsq = -10f * Time.deltaTime * ControleRotaçãoEsq;
        float CamSprint = 10f * Time.deltaTime * CamControleSprint;
        float CamAuto = 0.02f * Time.deltaTime * CamControleAuto;

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, RotaçãoCamDir, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, RotaçãoCamEsq, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0, 0, CamSprint);
        }
        else
        {

        }

        transform.Translate(0, 0, CamAuto);
    }
}
