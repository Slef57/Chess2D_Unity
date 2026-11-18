using System.Collections.Generic;
using UnityEngine;

public class Knight : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        
        List<Vector2Int> availableMoves = new List<Vector2Int>();
        
        // +1 X  +2 Y
        int targetX = posX + 1;
        int targetY = posY + 2;
        if (targetX <= 7 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // -1 X  +2 Y
        targetX = posX - 1;
        targetY = posY + 2;
        if (targetX >= 0 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // +1 X  -2 Y
        targetX = posX + 1;
        targetY = posY - 2;
        if (targetX <= 7 && targetY >= 0)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // -1 X  -2 Y
        targetX = posX - 1;
        targetY = posY - 2;
        if (targetX >= 0 && targetY >= 0)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // +2 X  +1 Y
        targetX = posX + 2;
        targetY = posY + 1;
        if (targetX <= 7 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // +2 X  -1 Y
        targetX = posX + 2;
        targetY = posY - 1;
        if (targetX <= 7 && targetY >= 0)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // -2 X  +1 Y
        targetX = posX - 2;
        targetY = posY + 1;
        if (targetX >= 0 && targetY <= 7)
        {
            Piece target = board[targetX, targetY];
            if (target == null || isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
            }
        }
        
        // -2 X  -1 Y
        targetX = posX - 2;
        targetY = posY - 1;
        if (targetX >= 0 && targetY >= 0)
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