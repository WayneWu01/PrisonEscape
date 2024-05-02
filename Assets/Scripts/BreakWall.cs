using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    public GameObject brick;
    public GameObject nextPuzzle;
    public GameObject smashedBrick;

    public AudioSource smashSound;

    // Start is called before the first frame update
    void Start()
    {
        brick.SetActive(true);
        nextPuzzle.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hammer"))
        {
            DestroyBrick();

            nextPuzzle.SetActive(true);
        }
    }

    private void DestroyBrick()
    {
        smashedBrick.SetActive(true);
        smashSound.Play();

        brick.SetActive(false); 
    }
}
