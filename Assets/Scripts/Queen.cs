using System.Collections.Generic;
using UnityEngine;

public class Queen : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        List<Vector2Int> availableMoves = new List<Vector2Int>();

        // Up
        bool obstacle = false;
        int count = 1;
        while (!obstacle)
        {
            int targetY = posY + count;

            if (targetY > 7)
            {
                break;
            }

            Piece target = board[posX, targetY];

            if (target == null)
            {
                availableMoves.Add(new Vector2Int(posX, targetY));
                count++;
            }
            else if (isWhite == target.isWhite)
            {
                obstacle = true;
            }
            else if (isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(posX, targetY));
                obstacle = true;
            }
        }

        // Down
        obstacle = false;
        count = 1;
        while (!obstacle)
        {
            int targetY = posY - count;

            if (targetY < 0)
            {
                break;
            }

            Piece target = board[posX, targetY];

            if (target == null)
            {
                availableMoves.Add(new Vector2Int(posX, targetY));
                count++;
            }
            else if (isWhite == target.isWhite)
            {
                obstacle = true;
            }
            else if (isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(posX, targetY));
                obstacle = true;
            }
        }

        // Right
        obstacle = false;
        count = 1;
        while (!obstacle)
        {
            int targetX = posX + count;

            if (targetX > 7)
            {
                break;
            }

            Piece target = board[targetX, posY];

            if (target == null)
            {
                availableMoves.Add(new Vector2Int(targetX, posY));
                count++;
            }
            else if (isWhite == target.isWhite)
            {
                obstacle = true;
            }
            else if (isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, posY));
                obstacle = true;
            }
        }

        // Left
        obstacle = false;
        count = 1;
        while (!obstacle)
        {
            int targetX = posX - count;

            if (targetX < 0)
            {
                break;
            }

            Piece target = board[targetX, posY];

            if (target == null)
            {
                availableMoves.Add(new Vector2Int(targetX, posY));
                count++;
            }
            else if (isWhite == target.isWhite)
            {
                obstacle = true;
            }
            else if (isWhite != target.isWhite)
            {
                availableMoves.Add(new Vector2Int(targetX, posY));
                obstacle = true;
            }
        }

        // Up Right
        obstacle = false;
        count = 1;
        while (!obstacle)
        {
            int targetX = posX + count;
            int targetY = posY + count;

            if (targetX > 7 || targetY > 7)
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

        // Up Left
        obstacle = false;
        count = 1;
        while (!obstacle)
        {
            int targetX = posX - count;
            int targetY = posY + count;

            if (targetX < 0 || targetY > 7)
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

        // Down Right
        obstacle = false;
        count = 1;
        while (!obstacle)
        {
            int targetX = posX + count;
            int targetY = posY - count;

            if (targetX > 7 || targetY < 0)
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

        // Down Left
        obstacle = false;
        count = 1;
        while (!obstacle)
        {
            int targetX = posX - count;
            int targetY = posY - count;

            if (targetX < 0 || targetY < 0)
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

        return availableMoves;
    }
}