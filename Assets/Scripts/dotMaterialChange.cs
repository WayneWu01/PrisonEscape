using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotMaterialChange : MonoBehaviour
{

    public GameObject dot;
    public Material[] material;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend =  GetComponent <Renderer> (); 
        rend.enabled = true;
        rend.sharedMaterial = material[0];  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            rend.sharedMaterial = material[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
