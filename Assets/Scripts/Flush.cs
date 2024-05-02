using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flush : MonoBehaviour
{
    public GameObject flusher;
    public GameObject chessPieceB;
    private ActiveSync chessSync;
    public Collider chessPieceCollider;
    public Collider toilet;
    private bool isChessInToilet = false;

    public AudioSource flushSound;
    // public AudioSource appearSound;

    // Start is called before the first frame update
    void Start()
    {
        chessSync = FindObjectOfType<ActiveSync>();
        chessSync.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (toilet.bounds.Intersects(chessPieceCollider.bounds))
        {
            isChessInToilet = true;
        }
        else
        {
            isChessInToilet = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("flusher"))
        {
            StartCoroutine(flush());
            flushSound.Play();

            if (isChessInToilet)
            {
                chessPieceB.SetActive(false);
                chessSync.SetActive(true);
            }
        }
    }

    IEnumerator flush()
    {
        flusher.transform.Rotate(0, 20, 0);
        yield return new WaitForSeconds(0.5f);
        for (int i=0; i<10; ++i)
        {
            flusher.transform.Rotate(0, -2, 0);
            yield return new WaitForSeconds(0.2f);
        }
        
    }
}
