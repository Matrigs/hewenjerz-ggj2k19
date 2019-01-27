﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int fim;
    public int dia = 1;
    public Gato gato;
    public Stalker gatinho;
    public List<NPC> NPCs;

    public bool mudadia = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mudadia == true)
        {
            dia++;
            foreach(NPC n in NPCs)
            {
                if(n.karma >= n.limitBom)
                {
                    Debug.Log(n.name+" BOM");
                }
                else if(n.karma < n.limitRuim)
                {
                    Debug.Log(n.name+" Ruim");
                }
                else 
                {
                    Debug.Log(n.name+" Neutro");
                }
                n.interagido = false;
                Debug.Log(n +" "+ n.interagido);
                if(dia == 2) 
                {
                    if(n.tag == "Adolescente") 
                    {
                        n.gameObject.SetActive(true);
                    }
                }
                if(dia == 3) 
                {
                    if(n.tag == "Gatinho") 
                    {
                        n.gameObject.SetActive(true);
                        n.gameObject.transform.position = new Vector3(gatinho.inicioX,gatinho.inicioY,gatinho.inicioZ);
                    }
                    if(n.tag == "Idoso") 
                    {
                        n.gameObject.SetActive(false);
                    }
                }
                if(dia == 4) 
                {
                    if(n.tag == "Gatinho") 
                    {
                        n.gameObject.transform.position = new Vector3(gatinho.inicioX,gatinho.inicioY,gatinho.inicioZ);
                    }
                    if(n.tag == "Adolescente") 
                    {
                        n.gameObject.SetActive(false);
                    }
                }
                if(dia == 5) 
                {
                    if(n.tag == "Gatinho") 
                    {
                        n.gameObject.transform.position = new Vector3(gatinho.inicioX,gatinho.inicioY,gatinho.inicioZ);
                    }
                    if(n.tag == "Adolescente") 
                    {
                        n.gameObject.SetActive(true);
                    }
                    if(n.tag == "Idoso") 
                    {
                        n.gameObject.SetActive(true);
                    }
                }
            }
            gatinho.stalking = false;
            Debug.Log("dia: "+dia);
            mudadia = false;
            if(dia >= fim) 
            {
                Debug.Log("FIM");
            }
        }
    }
}
