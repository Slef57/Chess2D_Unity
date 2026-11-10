using System.Collections.Generic;
using UnityEngine;

public class Pawn : Piece
{
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        return new List<Vector2Int>();
    }
}