using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDotColor : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    private bool black;

    // // Start is called before the first frame update
    void Start()
    {
        rend =  GetComponent <Renderer> (); 
        rend.enabled = true;
        rend.sharedMaterial = material[0];  
        black = false;
    }

    void OnCollisionEnter(Collision col) {
        // if (col.gameObject.tag == "BoxTest") {
        if (col.gameObject.tag == "Hand") {
            // rend.sharedMaterial = material[1];

            if (black) {
                rend.sharedMaterial = material[0];
                black = false;
            } else {
                rend.sharedMaterial = material[1];
                black = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            if (black) {
                rend.sharedMaterial = material[0];
                black = false;
            } else {
                rend.sharedMaterial = material[1];
                black = true;
            }
        }
    }

    public void enteredBox() {
        if (black) {
                rend.sharedMaterial = material[0];
                black = false;
            } else {
                rend.sharedMaterial = material[1];
                black = true;
            }
    }

    // void OnCollisionEnter (Collision col) {
    //     if (col.GameObject.tag == "BoxTest") {
    //         rend.sharedMaterial = material[1];
    //     } else {
    //         rend.sharedMaterial = material[2];
    //     }
    // }

}
