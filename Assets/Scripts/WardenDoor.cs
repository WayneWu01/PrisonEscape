using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WardenDoor : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    public UnityEvent onKeyInserted;

    private DoorSync doorSync;

    public bool opened;

    private void Start()
    {
        doorSync = GetComponent<DoorSync>();

        opened = false;
    }

    public void openDoor()
    {
        onKeyInserted.Invoke();

        if (!opened)
        {
            doorAnimator.Play("Warden Door", 0, 0.0f);
            opened = true;

            doorSync.SetOpened(opened);
        }
    }

}
