using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScenes : MonoBehaviour
{
    public string sceneName;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _gameManager.LoadSceneAndConnect("warden" + _gameManager.getRoomName(), sceneName);
    }
}
