using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterFound : MonoBehaviour
{
    public GameObject brick;
    public GameObject chessPiece;

    // Start is called before the first frame update
    void Start()
    {
        brick.SetActive(true);
        chessPiece.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hammer"))
        {
            brick.SetActive(false);
            chessPiece.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}


