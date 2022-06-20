using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Interage_Cave_Dois : MonoBehaviour
{

    public AudioSource audio_dois;

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
            (this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Cave_Cima_Dois"))
        {
            this.GetComponent<Animator>().Play("Cave_Desce_Dois");
            audio_dois.Play();

        }
        else
        {
            this.GetComponent<Animator>().Play("Cave_Sobe_Dois");
            audio_dois.Play();
        }
    }
}
