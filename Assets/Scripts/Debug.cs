using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Debug : MonoBehaviour
{
    [SerializeField] GameObject chesspiece;
    [SerializeField] TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "position: " + chesspiece.transform.position;
    }
}
