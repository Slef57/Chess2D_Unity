using System.Collections.Generic;
using UnityEngine;

public class King : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        List<Vector2Int> availableMoves = new List<Vector2Int>();
        
        bool obstacle = false;
        int count = 1;
        while (!obstacle && count < 4)
        {
            int targetX = posX -2 + count;
            int targetY = posY + 1;

            if (targetX > 7)
            {
                break;
            }

            Piece target = board[targetX, targetY];

            if (target == null)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
                count++;
            }
            else if (isWhite == target.isWhite)
            {
                obstacle = true;
            }
            else if (isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
                obstacle = true;
            }
        }
        
        obstacle = false;
        count = 1;
        while (!obstacle && count < 4)
        {
            int targetX = posX -2 + count;
            int targetY = posY - 1;

            if (targetX > 7)
            {
                break;
            }

            Piece target = board[targetX, targetY];

            if (target == null)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
                count++;
            }
            else if (isWhite == target.isWhite)
            {
                obstacle = true;
            }
            else if (isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, targetY));
                obstacle = true;
            }
        }
        
        Piece targetLeft = board[posX-1, posY];

        if (targetLeft == null)
        {
            availableMoves.Add(new Vector2Int(posX-1, posY));
        }
        else if (isWhite != targetLeft.isWhite)
        {
            availableMoves.Add(new Vector2Int(posX-1, posY));
        }
        
        Piece targetRight = board[posX+1, posY];

        if (targetRight == null)
        {
            availableMoves.Add(new Vector2Int(posX+1, posY));
        }
        else if (isWhite != targetRight.isWhite)
        {
            availableMoves.Add(new Vector2Int(posX+1, posY));
        }
        
        return availableMoves;
    }
}