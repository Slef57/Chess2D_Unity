using System.Collections.Generic;
using UnityEngine;

public class Pawn : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        List<Vector2Int> availableMoves = new List<Vector2Int>();

        // Up
        int targetX = posX;
        int targetY = posY + 1;
        if (targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // 2 up
        targetX = posX;
        targetY = posY + 2;
        if (targetY <= 7 && !hasMoved)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Up Right
        targetX = posX + 1;
        targetY = posY + 1;
        if (targetX <= 7 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target != null && isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // Up Left
        targetX = posX - 1;
        targetY = posY + 1;
        if (targetX > 0 && targetY > 0)
        {
            Piece target = board[targetX, targetY];
            if (target != null && isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        return availableMoves;
    }
}