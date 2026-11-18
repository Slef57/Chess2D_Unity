using System.Collections.Generic;
using UnityEngine;

public class King : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        List<Vector2Int> availableMoves = new List<Vector2Int>();
        
        // Up Left
        int targetX = posX - 1;
        int targetY = posY + 1;
        if (targetX >= 0 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Up
        targetX = posX;
        targetY = posY + 1;
        if (targetY <= 7)
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
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Right
        targetX = posX + 1;
        targetY = posY;
        if (targetX <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Down Right
        targetX = posX + 1;
        targetY = posY - 1;
        if (targetX <= 7 && targetY >= 0)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Down
        targetX = posX;
        targetY = posY - 1;
        if (targetY >= 0)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Down Left
        targetX = posX - 1;
        targetY = posY - 1;
        if (targetX >= 0 && targetY >= 0)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Left
        targetX = posX - 1;
        targetY = posY;
        if (targetX >= 0)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        return availableMoves;
    }
}