# Unity 2D Chess System

A 2D chess movement logic implementation in Unity (C#)

## 📁 Project Structure

```
Assets/
└── Assets/
    └── Scripts/
        ├── GameManager.cs
        ├── Piece.cs
        ├── King.cs
        ├── Pawn.cs
        ├── Rook.cs
        ├── Bishop.cs
        └── Queen.cs
```

## 🛠️ Code Structure

The project strictly consists of the following core scripts:

- **`Piece.cs`**: Abstract base class defining common properties (`posX`, `posY`, `isWhite`, `hasMoved`) and the virtual `GetAvailableMoves` interface.
- **`King.cs`**: 1-step movement logic covering all 8 adjacent directions using explicit, safe boundary checks.
- **`Pawn.cs`**: Forward movement (1 or 2 steps based on `hasMoved`) and conditional diagonal capture logic.
- **`Rook.cs`**: Straight orthogonal sliding logic using linear `while` loops.
- **`Bishop.cs`**: Diagonal sliding movement using 4-way diagonal `while` loops.
- **`Queen.cs`**: Combined orthogonal and diagonal sliding move calculations.
- **`GameManager.cs`**: Manages the main 2D logical board array (`Piece[8, 8]`).

## 🚀 Future Extensions

- **Knight Logic (`Knight.cs`):** Implementation of L-shaped movement patterns.
- **Special Chess Rules:**
  - Castling (King and Rook interaction).
  - En Passant pawn captures.
  - Pawn Promotion logic upon reaching the opposite rank.
- **Check & Checkmate Detection:** Validating move legality to prevent players from placing or leaving their King in check.
- **Turn Management & UI:** Turn-based gameplay loop, piece highlighting for valid moves, and visual board UI integration.
* **Customization & Themes:** Support for switching piece sprite sets (skins) and board themes dynamically.
