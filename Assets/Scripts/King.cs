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
        
        
        
        
        
        
        
        
        
        
        
        

        if (posX - 1>= 0 && posY + 1 <= 7)
        {
            Piece targetUpLeft = board[posX - 1, posY + 1];
            
            if (targetUpLeft == null)
            {
                availableMoves.Add(new Vector2Int(posX - 1, posY + 1));
            }
            else if (isWhite != targetUpLeft.isWhite)
            {
                availableMoves.Add(new Vector2Int(posX - 1, posY + 1));
            }
        }


        // Piece targetLeft = board[posX-1, posY];
        //
        // if (targetLeft == null)
        // {
        //     availableMoves.Add(new Vector2Int(posX-1, posY));
        // }
        // else if (isWhite != targetLeft.isWhite)
        // {
        //     availableMoves.Add(new Vector2Int(posX-1, posY));
        // }
        //
        // Piece targetRight = board[posX+1, posY];
        //
        // if (targetRight == null)
        // {
        //     availableMoves.Add(new Vector2Int(posX+1, posY));
        // }
        // else if (isWhite != targetRight.isWhite)
        // {
        //     availableMoves.Add(new Vector2Int(posX+1, posY));
        // }
        //
        // bool obstacle = false;
        // int count = 1;
        // while (!obstacle && count < 4)
        // {
        //     int targetX = posX -2 + count;
        //     int targetY = posY + 1;
        //
        //     if (targetX > 7)
        //     {
        //         break;
        //     }
        //
        //     Piece target = board[targetX, targetY];
        //
        //     if (target == null)
        //     {
        //         availableMoves.Add(new Vector2Int(targetX, targetY));
        //         count++;
        //     }
        //     else if (isWhite == target.isWhite)
        //     {
        //         obstacle = true;
        //     }
        //     else if (isWhite != target.isWhite)
        //     {
        //         availableMoves.Add(new Vector2Int(targetX, targetY));
        //         obstacle = true;
        //     }
        // }
        //
        // obstacle = false;
        // count = 1;
        // while (!obstacle && count < 4)
        // {
        //     int targetX = posX -2 + count;
        //     int targetY = posY - 1;
        //
        //     if (targetX > 7)
        //     {
        //         break;
        //     }
        //
        //     Piece target = board[targetX, targetY];
        //
        //     if (target == null)
        //     {
        //         availableMoves.Add(new Vector2Int(targetX, targetY));
        //         count++;
        //     }
        //     else if (isWhite == target.isWhite)
        //     {
        //         obstacle = true;
        //     }
        //     else if (isWhite != target.isWhite)
        //     {
        //         availableMoves.Add(new Vector2Int(targetX, targetY));
        //         obstacle = true;
        //     }
        // }

        return availableMoves;
    }
}