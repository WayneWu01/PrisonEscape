using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessScript : MonoBehaviour
{
    int triesLeft = 3;

    [SerializeField] GameObject chessBoard;
    [SerializeField] GameObject braillePuzzleCellA;

    [SerializeField] Collider chessPieceCollider;
    [SerializeField] Collider rightHandCollider;

    [SerializeField] GameObject errorMessage;

    // Start is called before the first frame update
    void Start()
    {
        braillePuzzleCellA.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncorrectSquare()
    {
        if (HoldingChessPiece())
        {
            triesLeft -= 1;
            if (triesLeft == 0)
            {
                // restart game
            }
        }
        else
        {
            ShowError();
        }
    }

    public void CorrectSquare()
    {
        if (HoldingChessPiece())
        {
            chessBoard.SetActive(false);
            braillePuzzleCellA.SetActive(true);
            //braillePuzzleCellB.SetActive(true);
        }
        else
        {
            ShowError();
        }
    }

    public bool HoldingChessPiece()
    {
        return chessPieceCollider.bounds.Intersects(rightHandCollider.bounds);
    }

    void ShowError()
    {
        errorMessage.SetActive(true);
        StartCoroutine(pause());
        
    }

    IEnumerator pause()
    {
        yield return new WaitForSeconds(2.0f);
        errorMessage.SetActive(false);
    }

}
