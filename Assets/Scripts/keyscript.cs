using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript : MonoBehaviour
{
    public GameObject visualKey;
    public GameObject grabbableKey;
    public Renderer keyMesh;

    public Rigidbody rbLock;

    private bool isUnlocked = false;

    private void Start()
    {
        keyMesh.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("key"))
        {
            visualKey.SetActive(true);
            keyMesh.enabled = false;
            isUnlocked = true;
        }
    }

    private void Update()
    {
        if (isUnlocked)
        {
            rbLock.MovePosition(grabbableKey.transform.position);
        }
    }

}
