using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardenExit : MonoBehaviour
{
    private GameManager _gameManager;

    // just for testing
    private MeshRenderer meshRenderer;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //meshRenderer.enabled = true;

            _gameManager.LoadSceneAndConnect("finish" + _gameManager.getRoomName(), "Freedom");
        }
    }
}
