using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalker : MonoBehaviour
{
    public bool stalking = false;
    public Gato gato;
    public float offset = 0.5f;

    public float inicioX;
    public float inicioY;
    public float inicioZ;

    public Animator walk;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(stalking == true) 
        {
            if(gato.facingRight == true) 
            {
                if(this.transform.position.x + offset < gato.transform.position.x)
                {
                     transform.Translate((gato.velocidadeX * Time.deltaTime), 0, 0);
                     walk.SetBool("Walk",true);
                }
                else
                {
                    walk.SetBool("Walk",false);
                }
            }
            else 
            {
                if(this.transform.position.x - offset > gato.transform.position.x)
                {
                    transform.Translate((-gato.velocidadeX * Time.deltaTime), 0, 0);
                    walk.SetBool("Walk",true);
                }
                else
                {
                    walk.SetBool("Walk",false);
                }
            }
        }
    }
}
