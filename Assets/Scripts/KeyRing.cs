using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRing : MonoBehaviour
{
    public GameObject[] keys;

    //public void Start()
    //{
    //    StartCoroutine("test");
    //}

    //public IEnumerator test()
    //{
    //    yield return new WaitForSeconds(3);

    //    Unhighlight();
    //}

    public void Highlight()
    {
        foreach (GameObject piece in keys) {
            MaterialFlash materialControl = piece.GetComponent<MaterialFlash>();
            materialControl.FlashStart();

            Glow glowControl = piece.GetComponent<Glow>();
            glowControl.GlowStart();
        }
    }

    public void Unhighlight()
    {
        foreach (GameObject piece in keys)
        {
            MaterialFlash materialControl = piece.GetComponent<MaterialFlash>();
            materialControl.FlashStop();

            Glow glowControl = piece.GetComponent<Glow>();
            glowControl.GlowStop();
        }
    }
}
