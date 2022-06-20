using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Interage_Porta_Entrada_Cave : MonoBehaviour
{
    public AudioSource audio;

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
            audio.Play();
        }
        else
        {
            this.GetComponent<Animator>().Play("Cave_Sobe");
            audio.Play();
        }
    }
}
