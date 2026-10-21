using System;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{

    private Piece[,] board = new Piece[8, 8];

    public GameObject queenPiecePrefab;
    
    void Start()
    {
        SpawnSinglePiece(queenPiecePrefab, 4, 6);
    }

    private void setupBoard()
    {
        
    }

    private void SpawnSinglePiece(GameObject piecePrefab, int x, int y)
    {
        GameObject pieceGameObject = Instantiate(piecePrefab, new Vector3(x, y, 0), Quaternion.identity);

        Piece piece = pieceGameObject.GetComponent<Piece>();

        piece.posX = x;
        piece.posY = y;

        board[x, y] = piece;
    }
    
}
