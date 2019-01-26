using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{


    public float velocidadeX = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
}
