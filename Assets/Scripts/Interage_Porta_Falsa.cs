using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interage_Porta_Falsa : MonoBehaviour
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
            (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Falsa_Aberta"))
        {
            this.GetComponent<Animator>().Play("Move_Lado_Inv");
            
        }
        else
        {
            this.GetComponent<Animator>().Play("Move_Lado");
            
        }
    }
}
