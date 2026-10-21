using UnityEngine;

public class GameManager : MonoBehaviour
{

    private Piece[,] board = new Piece[8, 8];

    public GameObject rookPiece;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(rookPiece, new Vector3(3, 4, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
