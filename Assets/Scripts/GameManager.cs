using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 2D array holding the board's logical state
    private Piece[,] board = new Piece[8, 8];

    public GameObject highlightPrefab;
    
    // Piece prefabs
    [Header("White Pieces")] 
    public GameObject whitePawnPrefab;
    public GameObject whiteRookPrefab;
    public GameObject whiteKnightPrefab;
    public GameObject whiteBishopPrefab;
    public GameObject whiteQueenPrefab;
    public GameObject whiteKingPrefab;

    [Header("Black Pieces")] 
    public GameObject blackPawnPrefab;
    public GameObject blackRookPrefab;
    public GameObject blackKnightPrefab;
    public GameObject blackBishopPrefab;
    public GameObject blackQueenPrefab;
    public GameObject blackKingPrefab;

    // The piece currently selected by the player
    private Piece activePiece;
    
    // All the active highlights
    private List<GameObject> activeHighlights = new List<GameObject>();
    
    void Start() {
        SetupBoard();
    }

    // Sets up the starting positions of all the pieces on the board
    private void SetupBoard()
    {
        
        // Spawn White back Pieces ( Row 0 )
        SpawnSinglePiece(whiteRookPrefab, 0, 0, 1);
        SpawnSinglePiece(whiteKnightPrefab, 1, 0, 1);
        SpawnSinglePiece(whiteBishopPrefab, 2, 0, 1);
        SpawnSinglePiece(whiteQueenPrefab, 3, 0);
        SpawnSinglePiece(whiteKingPrefab, 4, 0);
        SpawnSinglePiece(whiteBishopPrefab, 5, 0, 2);
        SpawnSinglePiece(whiteKnightPrefab, 6, 0 , 2);
        SpawnSinglePiece(whiteRookPrefab, 4, 3, 2); //set for testing ( should be x 7 y 0 )
        
        SpawnSinglePiece(whitePawnPrefab, 2, 3); // for testing
        
        // Spawn White Pawns ( Row 1 ) ( now 1 less for testing)
        for (int i = 0; i < 7; i++)
        {
            SpawnSinglePiece(whitePawnPrefab, i, 1, i+1);
        }
        
        // Spawn Black Pawns ( Row 6 ) ( now 1 less for testing)
        for (int i = 0; i < 7; i++)
        {
            SpawnSinglePiece(blackPawnPrefab, i, 6, i+1);
        }
        
        // Spawn Black back Pieces ( Row 7 )
        SpawnSinglePiece(blackRookPrefab, 0, 7, 1);
        SpawnSinglePiece(blackKnightPrefab, 1, 7, 1);
        SpawnSinglePiece(blackBishopPrefab, 2, 7, 1);
        SpawnSinglePiece(blackQueenPrefab, 3, 7);
        SpawnSinglePiece(blackKingPrefab, 4, 7);
        SpawnSinglePiece(blackBishopPrefab, 5, 7, 2);
        SpawnSinglePiece(blackKnightPrefab, 6, 7, 2);
        SpawnSinglePiece(blackRookPrefab, 7, 7, 2);
    }

    // Helper: Spawns a piece and registers it to the board array.
    private void SpawnSinglePiece(GameObject piecePrefab, int x, int y, int pieceNo = 0)
    {
        // 1. Spawn visual object.
        GameObject pieceGameObject = Instantiate(piecePrefab, new Vector3(x, y, 0), Quaternion.identity);

        
        // 2. Setup name.
        string finalName = piecePrefab.name;
        if (pieceNo > 0)
        {
            finalName = finalName + "_" + pieceNo;
        }

        pieceGameObject.name = finalName;
        
        
        // 3. Get the piece script.
        Piece piece = pieceGameObject.GetComponent<Piece>();

        // 4. Update internal coordinates.
        piece.posX = x;
        piece.posY = y;

        // 5. Register to board.
        board[x, y] = piece;
    }

    public void SelectPiece(Piece clickedPiece)
    {
        
        // 1. Clear any existing highlights from a previous selection
        ClearAllHighlights();
        
        // 2. Register the newly clicked piece
        activePiece = clickedPiece;
        
        // 3. Highlight the square the piece is currently standing on
        HighlightSquare(activePiece.posX, activePiece.posY);
        
        // 4. Retrieve all legal moves for this specific piece
        List<Vector2Int> availableMoves = activePiece.GetAvailableMoves(board);

        // 5. Highlight every square the piece can legally move to
        foreach (Vector2Int move in availableMoves)
        {
            HighlightSquare(move.x, move.y);
        }
        
        // 6. Log the selection to the console for debugging
        Debug.Log("Selected Piece is " + activePiece.gameObject.name);
    }
    
    // Helper: Highlights a square
    private void HighlightSquare(int x, int y)
    {
        activeHighlights.Add(Instantiate(highlightPrefab, new Vector3(x, y, 0), Quaternion.identity));
    }
    
    // Helper: Clears all highlights
    private void ClearAllHighlights()
    {
        foreach (GameObject highlight in activeHighlights)
        {
            Destroy(highlight);
        }
        activeHighlights.Clear();
    }
}