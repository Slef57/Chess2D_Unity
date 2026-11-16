using System.Collections.Generic;
using UnityEngine;

public class Pawn : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        List<Vector2Int> availableMoves = new List<Vector2Int>();
        int direction = 1;

        if (!isWhite)
        {
            direction = -1;
        }
        

        // Up ( or "Down" for black pawns )
        int targetX = posX;
        int targetY = posY + direction;
        if (targetY >= 0 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // 2 up
        targetX = posX;
        targetY = posY + 2 * direction;
        if (targetY >= 0 && targetY <= 7 && !hasMoved)
        {
            Piece target = board[targetX, targetY];
            Piece target1Up = board[targetX, posY + direction];
            if (target == null && target1Up == null)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }

        // Up Right
        targetX = posX + 1;
        targetY = posY + direction;
        if (targetX <= 7 && targetY >= 0 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target != null && isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // Up Left
        targetX = posX - 1;
        targetY = posY + direction;
        if (targetX >= 0 && targetY >= 0 && targetY <= 7)
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