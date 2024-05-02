using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorOpener : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    public UnityEvent onKeyInserted;

    private bool opened;

    private void Start()
    {
        opened = false;
    }

    public void openDoor()
    {
        onKeyInserted.Invoke();

        if (!opened)
        {
            doorAnimator.Play("Door Open", 0, 0.0f);
            opened = true;
        }
    }

}
