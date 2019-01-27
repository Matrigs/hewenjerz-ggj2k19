using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int fim;
    private int dia = 1;
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
            }
            gatinho.stalking = false;
            dia++;
            mudadia = false;
            if(dia >= fim) 
            {
                Debug.Log("FIM");
            }
        }
    }
}
