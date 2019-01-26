using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gato : MonoBehaviour
{
    public List<NPC> NPCs;
    private NPC npc;
    public GameObject cama;

    public GameManager gameManager;
    public float velocidadeX = 10f;
    public bool interacao = false;
    private bool camab = false;
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
        if (paineliteracao.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Fechou");
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Neutro");
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Negativo");
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Positivo");
            }
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow) && camab == false )
        {
            paineliteracao.SetActive(true);
            interacao = true;
            Debug.Log("abriu");
        }

    }

    private void OnTriggerStay(Collider other)
    {
         foreach(NPC n in NPCs)
         {
             if(n.name == other.name) 
             {
                npc = n;
             }
         }  
        if(interacao == true && npc.name == other.name && npc.interagido == false) 
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                npc.neutro = true;
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Neutro");
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                npc.arranhado = true;
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Negativo");
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                npc.acariciado = true;
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Positivo");
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                paineliteracao.SetActive(false);
                interacao = false;
                Debug.Log("Fechou");
            }
            npc = null;
        }
        if(cama.name == other.name) 
        {
            camab = true;
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                gameManager.mudadia = true;
            }
        }
        Debug.Log(other);
    }
    private void OnTriggerExit(Collider other)
    {
        camab = false;
    }
}
