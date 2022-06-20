using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interage_porta_cabine : MonoBehaviour
{
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
            (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Porta_Aberta")) 
        { 
            this.GetComponent<Animator>().Play("Fechar"); 
        } 
        else 
        { 
            this.GetComponent<Animator>().Play("Abre"); 
        } 
    }
}
