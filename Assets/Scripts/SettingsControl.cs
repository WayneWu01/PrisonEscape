using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsControl : MonoBehaviour
{
    private GameManager _gameManager;

    [Header("Button Textures")]
    [SerializeField] private Sprite red;
    [SerializeField] private Sprite green;

    [Header("Music")]
    [SerializeField] private Image musicButton;
    private Text musicText;

    [Header("Colors")]
    [SerializeField] private Image blueButton;
    private Text blueText;
    [SerializeField] private Image greenButton;
    private Text greenText;
    [SerializeField] private Image pinkButton;
    private Text pinkText;
    [SerializeField] private Image redButton;
    private Text redText;


    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

        musicText = musicButton.GetComponentInChildren<Text>();

        blueText = blueButton.GetComponentInChildren<Text>();
        greenText = greenButton.GetComponentInChildren<Text>();
        pinkText = pinkButton.GetComponentInChildren<Text>();
        redText = redButton.GetComponentInChildren<Text>();

        musicText.text = "✔";
        blueText.text = "✔";
    }

    public void toggleMusic()
    {
        _gameManager.backgroundMusic = !_gameManager.backgroundMusic;

        if (_gameManager.backgroundMusic)
        {
            musicButton.sprite = green;
            musicText.text = "✔";
        }
        else
        {
            musicButton.sprite = red;
            musicText.text = "X";
        }
    }

    public void bluePressed()
    {
        _gameManager.colorChoice = GameManager.Colors.Blue;

        blueText.text = "✔";

        greenText.text = null;
        pinkText.text = null;
        redText.text = null;
    }

    public void greenPressed()
    {
        _gameManager.colorChoice = GameManager.Colors.Green;

        greenText.text = "✔";

        blueText.text = null;
        pinkText.text = null;
        redText.text = null;
    }

    public void pinkPressed()
    {
        _gameManager.colorChoice = GameManager.Colors.Pink;

        pinkText.text = "✔";

        blueText.text = null;
        greenText.text = null;
        redText.text = null;
    }

    public void redPressed()
    {
        _gameManager.colorChoice = GameManager.Colors.Red;

        redText.text = "✔";

        greenText.text = null;
        pinkText.text = null;
        blueText.text = null;
    }
}
