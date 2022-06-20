using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interage_Cave_Porta : MonoBehaviour
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
            (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Cave_Cima"))
        {
            this.GetComponent<Animator>().Play("Cave_Desce");
        }
        else
        {
            this.GetComponent<Animator>().Play("Cave_Sobe");
        }
    }
}
