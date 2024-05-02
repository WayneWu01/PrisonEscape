using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessButtonScript : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] GameObject incorrectSquare;
    [SerializeField] GameObject chessBoard;
    ChessScript chessScript;

    private void Awake()
    {
        chessScript = chessBoard.GetComponent<ChessScript>();
    }

    public void SquarePressed()
    {
        if (chessScript.HoldingChessPiece())
        {
            button.SetActive(false);
            incorrectSquare.SetActive(true);
        }
    }

}
