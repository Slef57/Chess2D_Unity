using System.Collections.Generic;
using UnityEngine;

public class Knight : Piece
{
    
    public override List<Vector2Int> GetAvailableMoves(Piece[,] board)
    {
        return new List<Vector2Int>();
    }
    
}