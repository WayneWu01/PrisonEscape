using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockArea : MonoBehaviour
{
    public GameObject[] locks;

    public void Start()
    {
        Unhighlight();
    }

    public void Highlight()
    {
        foreach (GameObject area in locks) {
            MaterialFlash materialControl = area.GetComponent<MaterialFlash>();
            materialControl.FlashStart();

            Glow glowControl = area.GetComponent<Glow>();
            glowControl.GlowStart();
        }
    }

    public void Unhighlight()
    {
        foreach (GameObject area in locks)
        {
            MaterialFlash materialControl = area.GetComponent<MaterialFlash>();
            materialControl.FlashStop();

            Glow glowControl = area.GetComponent<Glow>();
            glowControl.GlowStop();
        }
    }
}
