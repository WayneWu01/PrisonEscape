using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenExit : MonoBehaviour
{
    public GameObject letterTile1;
    public GameObject letterTile2;
    public GameObject letterTile3;
    public ActiveSync wall;

    public AudioSource wallSound;

    // Start is called before the first frame update
    void Start()
    {
        wall.SetActive(true);
    }

    void Update()
    {
        if (letterTile1.activeInHierarchy && letterTile2.activeInHierarchy && letterTile3.activeInHierarchy ) {
            wall.SetActive(false);
            wallSound.Play();
        }
        
    }
}
