using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Interage_Estante_Falsa : MonoBehaviour
{
    public AudioSource Estante;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    { 
    }

    private void OnMouseDown()
    {
        if
            (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Estante_Aberta_Lateral"))
        {
            this.GetComponent<Animator>().Play("Estante_Fecha_Lateral");
            Estante.Play();
        }
        else
        {
            this.GetComponent<Animator>().Play("Estante_Abre_Lateral");
            Estante.Play();
        }
    }
}
