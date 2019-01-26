using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Gato gato;
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
            foreach(NPC n in NPCs)
            {
                n.interagido = false;
            }
            mudadia = false;
        }
    }
}
