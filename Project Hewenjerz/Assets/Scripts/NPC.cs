using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public bool arranhado = false;
    public bool interagido = false;
    public bool acariciado = false;
    public int variacaoKarma;

    public int karma = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(arranhado == true)
        {
            karma = karma - variacaoKarma;
            arranhado = false;
        }

        if (acariciado == true)
        {
            karma = karma + variacaoKarma;
            acariciado = false;
        }
    }


}
