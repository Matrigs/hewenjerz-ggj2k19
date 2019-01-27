using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gato : MonoBehaviour
{
    public List<NPC> NPCs;
    private NPC npc;

    private bool count = false;
    public GameObject cama;

    public GameManager gameManager;

	public Animator catAnim;
	public Animator fadeAnimator;
    public float velocidadeX = 10f;
    public bool interacao = false;
    private bool camab = false;

    public bool facingRight = false;

    Vector3 X;
    public GameObject paineliteracao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frameS
    void Update()
    {
        if (interacao == false)
        {
            //DIREITA
            if (Input.GetKey("d"))
            {
                //Debug.Log("aaaaaa");
				catAnim.SetBool("Walk", true);
                transform.Translate((velocidadeX * Time.deltaTime), 0, 0);
                if(facingRight == false)
                {
                    // Switch the way the player is labelled as facing
                    facingRight = !facingRight;

                    // Multiply the player's x local scale by -1
                    Vector3 theScale = transform.localScale;
                    theScale.x *= -1;
                    transform.localScale = theScale;
                }                
               
            }
            //ESQUERDA
            else if (Input.GetKey("a"))
            {
				catAnim.SetBool("Walk", true);
				transform.Translate((-velocidadeX * Time.deltaTime), 0, 0);

                if(facingRight == true)
                {
                    // Switch the way the player is labelled as facing
                    facingRight = !facingRight;

                    // Multiply the player's x local scale by -1
                    Vector3 theScale = transform.localScale;
                    theScale.x *= -1;
                    transform.localScale = theScale;

                }
                    
            }
            else
            {
                catAnim.SetBool("Walk", false);
                transform.Translate(0, 0, 0);
            }
        }
        if (paineliteracao.activeSelf)
        {
			catAnim.SetBool("Walk", false);
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
            foreach(NPC n in NPCs)
            {
                if(n.interagido == true) 
                {
                    count = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && count == true)
            {
				fadeAnimator.SetTrigger("FadeOut");
				StartCoroutine (fadeInDelayer());
                count = false;
            }
        }
        Debug.Log(other);
    }
    private void OnTriggerExit(Collider other)
    {
        camab = false;
    }

	IEnumerator fadeInDelayer () {
		yield return StartCoroutine (WaitForRealSeconds(1));
		Time.timeScale = 1f;

		gameManager.mudadia = true;

		yield return StartCoroutine (WaitForRealSeconds(1));

		fadeAnimator.SetTrigger ("FadeIn");
		fadeAnimator.updateMode = AnimatorUpdateMode.Normal;
	}

	public static IEnumerator WaitForRealSeconds (float time) {
		float start = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup < start + time) {
			yield return null;
		}
	}
}
