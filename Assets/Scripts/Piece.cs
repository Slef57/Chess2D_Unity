using UnityEngine;

public class Piece : MonoBehaviour
{

    // The position of the Piece on the board ( from 0 to 7 )
    public int posX;
    public int posY;
    
    // The colour of the pice ( black or white )
    public bool isWhite;
    
    // True is the Piece has ever moved 
    public bool hasMoved = false;

    public virtual void GetAvailableMoves()
    {
        
    }
}
