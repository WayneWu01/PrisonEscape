using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BackgroundMusic : MonoBehaviour
{
    private AudioSource music;
    private GameManager _gameManager;

    [SerializeField] private bool playing = true;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

        music = this.gameObject.GetComponent(typeof(AudioSource)) as AudioSource;
    }

    private void Update()
    {
        music.mute = !_gameManager.backgroundMusic;
        playing = _gameManager.backgroundMusic;
    }

}
