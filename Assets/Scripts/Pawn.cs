using System.Collections.Generic;
using UnityEngine;

public class Pawn : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        List<Vector2Int> availableMoves = new List<Vector2Int>();

        
        // Needs fix
        
        // Piece targetUp = board[posX, posY + 1];
        //
        // if (targetUp == null)
        // {
        //     availableMoves.Add(new Vector2Int(posX, posY + 1));
        // }
        //
        // Piece target2Up = board[posX, posY + 2];
        //
        // if (target2Up == null && !hasMoved)
        // {
        //     availableMoves.Add(new Vector2Int(posX, posY + 2));
        // }
        //
        // Piece targetRightUp = board[posX + 1, posY + 1];
        //
        // if (targetRightUp != null && isWhite != targetRightUp.isWhite)
        // {
        //     availableMoves.Add(new Vector2Int(posX + 1, posY + 1));
        // }
        //
        // Piece targetLeftUp = board[posX - 1, posY + 1];
        //
        // if (targetLeftUp != null && isWhite != targetLeftUp.isWhite)
        // {
        //     availableMoves.Add(new Vector2Int(posX - 1, posY + 1));
        // }

        return availableMoves;
    }
}