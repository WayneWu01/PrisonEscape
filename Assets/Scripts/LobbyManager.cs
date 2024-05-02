using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Normal.Realtime;
using TMPro;

public class LobbyManager : MonoBehaviour
{
    [SerializeField]
    private Realtime _realtime;
    private RealtimeAvatarManager _avatarManager;

    private GameManager _gameManager;

    public TextMeshProUGUI playerCountText;
    public TextMeshProUGUI startInstructions;
    public TextMeshProUGUI gameCode;

    private int numPlayers;
    private string playerCountPrefix;

    private string tooFewInstructions;
    private string enoughInstructions;

    private void Awake()
    {
        _avatarManager = _realtime.GetComponent<RealtimeAvatarManager>();
        //DontDestroyOnLoad(_realtime);
        //DontDestroyOnLoad(_avatarManager);
    }

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

        //_ = _gameManager.gameObject.AddComponent(typeof(SceneSync)) as SceneSync;

        numPlayers = 0;

        // set text

        playerCountPrefix = "Players in game: ";

        tooFewInstructions = "The game requires at least 2 players.";
        enoughInstructions = "Each player press the red button to begin.";

        startInstructions.text = tooFewInstructions;

        gameCode.text = "Game code: " + _gameManager.getRoomName();
    }

    private void Update()
    {
       if (_avatarManager.avatars.Count > numPlayers)
        {
            numPlayers = _avatarManager.avatars.Count;
        }
        
        playerCountText.text = playerCountPrefix + numPlayers;

        startInstructions.text = numPlayers < 2 ? tooFewInstructions : enoughInstructions;
    }

    public void ButtonPressed()
    {
        if (numPlayers >= 2)
        {
            SendToCell();
        }
        else
        {
            // WONT ACTUALLY LET YOU START NORMALLY
            // STARTS WITH 1 ONLY FOR TESTING PURPOSES
            SendToCell();
        }
    }

    private void SendToCell()
    {
        //_realtime.Connect("cell" + gameCode);

        //SceneManager.LoadScene("Cell");

        _gameManager.LoadSceneAndConnect("cell" + _gameManager.getRoomName(), "Cell");
    }

}
