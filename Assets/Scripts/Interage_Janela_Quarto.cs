using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Interage_Janela_Quarto : MonoBehaviour
{
    public AudioSource Janela;
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
            (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Janela_Aberta"))
        {
            this.GetComponent<Animator>().Play("Janela_Fecha");
            Janela.Play();
        }
        else
        {
            this.GetComponent<Animator>().Play("Janela_Abre");
            Janela.Play();
        }
    }
}
