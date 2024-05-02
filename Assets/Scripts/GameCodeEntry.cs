using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCodeEntry : MonoBehaviour
{
    public Text codeText;
    public string code;

    private GameManager _gameManager;

    private string _default = "Enter game code...";

    public void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        codeText.text = _default;
    }

    public void PressedNumber(int number)
    {
        if (code.Length < 16 || code.Equals(_default))
        {
            code += number.ToString();
            codeText.text = code;
        }
    }

    public void PressedDelete()
    {
        code = code.Substring(0, (code.Length - 1));

        if (System.String.IsNullOrEmpty(code))
        {
            codeText.text = _default;
        }
        else
        {
            codeText.text = code;
        }
    }

    public void PressedEnter()
    {
        if (code.Length == 3)
        {
            _gameManager.LoadSceneAndConnect(code, "Lobby");
        }
    }
}
