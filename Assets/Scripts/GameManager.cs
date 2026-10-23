using UnityEngine;


public class GameManager : MonoBehaviour
{
    // 2D array holding the board's logical state
    private Piece[,] board = new Piece[8, 8];

    // Piece prefabs
    [Header("White Pieces")] public GameObject whitePawnPrefab;
    public GameObject whiteRookPrefab;
    public GameObject whiteKnightPrefab;
    public GameObject whiteBishopPrefab;
    public GameObject whiteQueenPrefab;
    public GameObject whiteKingPrefab;

    [Header("Black Pieces")] public GameObject blackPawnPrefab;
    public GameObject blackRookPrefab;
    public GameObject blackKnightPrefab;
    public GameObject blackBishopPrefab;
    public GameObject blackQueenPrefab;
    public GameObject blackKingPrefab;

    void Start()
    {
        SetupBoard();
    }

    // Sets up the starting positions of all the pieces on the board
    private void SetupBoard()
    {
        
        // Spawn White back Pieces ( Row 0 )
        SpawnSinglePiece(whiteRookPrefab, 0, 0);
        SpawnSinglePiece(whiteKnightPrefab, 1, 0);
        SpawnSinglePiece(whiteBishopPrefab, 2, 0);
        SpawnSinglePiece(whiteQueenPrefab, 3, 0);
        SpawnSinglePiece(whiteKingPrefab, 4, 0);
        SpawnSinglePiece(whiteBishopPrefab, 5, 0);
        SpawnSinglePiece(whiteKnightPrefab, 6, 0);
        SpawnSinglePiece(whiteRookPrefab, 7, 0);
        
        // Spawn White Pawns ( Row 1 )
        for (int i = 0; i < 8; i++)
        {
            SpawnSinglePiece(whitePawnPrefab, i, 1);
        }
        
        // Spawn Black Pawns ( Row 6 )
        for (int i = 0; i < 8; i++)
        {
            SpawnSinglePiece(blackPawnPrefab, i, 6);
        }
        
        // Spawn Black back Pieces ( Row 7 )
        SpawnSinglePiece(blackRookPrefab, 0, 7);
        SpawnSinglePiece(blackKnightPrefab, 1, 7);
        SpawnSinglePiece(blackBishopPrefab, 2, 7);
        SpawnSinglePiece(blackQueenPrefab, 3, 7);
        SpawnSinglePiece(blackKingPrefab, 4, 7);
        SpawnSinglePiece(blackBishopPrefab, 5, 7);
        SpawnSinglePiece(blackKnightPrefab, 6, 7);
        SpawnSinglePiece(blackRookPrefab, 7, 7);
        
    }

    // Helper: Spawns a piece and registers it to the board array.
    private void SpawnSinglePiece(GameObject piecePrefab, int x, int y)
    {
        // 1. Spawn visual object.
        GameObject pieceGameObject = Instantiate(piecePrefab, new Vector3(x, y, 0), Quaternion.identity);

        // 2. Get the piece script.
        Piece piece = pieceGameObject.GetComponent<Piece>();

        // 3. Update internal coordinates.
        piece.posX = x;
        piece.posY = y;

        // 4. Register to board logic.
        board[x, y] = piece;
    }
}