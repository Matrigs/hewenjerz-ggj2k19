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

    public int karma = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(interagido == false) 
        {
            if(arranhado == true)
            {
                karma = karma - variacaoKarma;
                arranhado = false;
                Debug.Log(karma);
                interagido = true;
            }

            if (acariciado == true)
            {
                karma = karma + variacaoKarma;
                acariciado = false;
                Debug.Log(karma);
                interagido = true;
            }

            if(neutro == true)
            {
                neutro = false;
                interagido = true;
            }
        }
    }
}
