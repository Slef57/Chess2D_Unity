using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 2D array holding the board's logical state
    private Piece[,] board = new Piece[8, 8];

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

    // THe piece currently selected by the player
    private Piece activePiece;
    
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
        SpawnSinglePiece(whiteRookPrefab, 7, 0, 2);
        
        // Spawn White Pawns ( Row 1 )
        for (int i = 0; i < 8; i++)
        {
            SpawnSinglePiece(whitePawnPrefab, i, 1, i+1);
        }
        
        // Spawn Black Pawns ( Row 6 )
        for (int i = 0; i < 8; i++)
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
        activePiece = clickedPiece;
        Debug.Log("Selected Piece is " + activePiece.gameObject.name);
    }
    
}