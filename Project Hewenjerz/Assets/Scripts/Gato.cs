using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gato : MonoBehaviour
{


    public float velocidadeX = 10f;
    public bool interacao = false;
    public GameObject paineliteracao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (interacao == false)
        {
            //DIREITA
            if (Input.GetKey("d"))
            {
                //Debug.Log("aaaaaa");
                transform.Translate((velocidadeX * Time.deltaTime), 0, 0);
            }

            //ESQUERDA
            if (Input.GetKey("a"))
            {
                transform.Translate((-velocidadeX * Time.deltaTime), 0, 0);
            }
        }

        if (Input.GetKey("space"))
        {
            paineliteracao.SetActive(true);
            interacao = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            paineliteracao.SetActive(false);
            interacao = false;
        }

        if (paineliteracao.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Neutro");
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Debug.Log("Negativo");
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Debug.Log("Positivo");
            }
        }
            

    }
}
