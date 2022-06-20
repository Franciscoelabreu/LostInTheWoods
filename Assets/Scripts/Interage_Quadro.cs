using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interage_Quadro : MonoBehaviour
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
             (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("quadro_caido"))
        {
            this.GetComponent<Animator>().Play("quadro_volta");
        }
        else
        {
            this.GetComponent<Animator>().Play("cai_quadro");
        }
    }
}

