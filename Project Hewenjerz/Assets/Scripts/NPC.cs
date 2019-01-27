using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int limitBom;
    public int limitRuim;
    public bool arranhado = false;
    public bool interagido = false;
    public bool acariciado = false;
    public bool neutro = false;
    public int variacaoKarma = 10;
    public Stalker gatinho;
    public GameManager gameManager;
    public int karma = 50;
    public Animator leit;
    public Animator resmunga;
    public Animator mia;
    public Animator acaricia;
    public Animator acaricia2;
    public Animator chutar;
    public Animator afugenta;
    public Animator arranha;
    public Animator bate;
    public Animator veneno;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(interagido == false) 
        {
            Debug.Log("Entre porra caralho");
            if(arranhado == true)
            {
                karma = karma - variacaoKarma;
                arranhado = false;
                Debug.Log(karma);
                interagido = true;
                if(gameManager.dia == 5)
                    if(this.tag == "Gatinho") 
                    {
                        //O gato rouba leite
                    }
                    if(this.tag == "Idoso") 
                    {
                        bate.SetBool("Bate",true);
                    }
                    if(this.tag == "Adolescente") 
                    {
                        veneno.SetBool("Veneno",true);
                    }
                else 
                {
                     if(this.tag == "Gatinho") 
                    {
                        arranha.SetBool("Arranha",true);
                    }
                    if(this.tag == "Idoso") 
                    {
                        afugenta.SetBool("Afugenta",true);
                    }
                    if(this.tag == "Adolescente") 
                    {
                        chutar.SetBool("Chutar",true);
                    }
                }
            }

            if (acariciado == true)
            {
                karma = karma + variacaoKarma;
                acariciado = false;
                Debug.Log(karma);
                interagido = true;
                if(gameManager.dia == 5) 
                {
                     if(this.tag == "Gatinho") 
                    {
                        //Animacao
                    }
                    if(this.tag == "Idoso") 
                    {
                        acaricia2.SetBool("Acaricia2", true);
                    }
                    if(this.tag == "Adolescente") 
                    {
                        //Animacao
                    }
                }
                else 
                {
                    if(this.tag == "Gatinho") 
                    {
                        gatinho.stalking = true;
                    }
                    if(this.tag == "Idoso") 
                    {
                        resmunga.SetBool("Resmunga",true);
                    }
                    if(this.tag == "Adolescente") 
                    {
                        acaricia.SetBool("Acaricia",true);
                    }
                }
                
            }

            if(neutro == true)
            {
                neutro = false;
                interagido = true;
                if(gameManager.dia == 5) 
                {
                    if(this.tag == "Gatinho") 
                    {
                        mia.SetBool("Mia",true);
                    }
                    if(this.tag == "Idoso") 
                    {
                        resmunga.SetBool("Resmunga", true);
                    }
                    if(this.tag == "Adolescente") 
                    {
                        
                    }
                }
                else 
                {
                    if(this.tag == "Gatinho") 
                    {
                        mia.SetBool("Mia",true);
                    }
                    if(this.tag == "Idoso") 
                    {
                        resmunga.SetBool("Resmunga", true);
                    }
                    if(this.tag == "Adolescente") 
                    {
                        leit.SetBool("Leite", true);
                    }
                }
            }
        }
    }
}
