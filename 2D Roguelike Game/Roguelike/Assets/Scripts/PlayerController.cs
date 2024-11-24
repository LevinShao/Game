using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private BoardManager m_Board; // Reference to the BoardManager
    private Vector2Int m_CellPosition; // Current cell position of the player

    // Spawns the player on the board at a specific cell
    public void Spawn(BoardManager boardManager, Vector2Int cell)
    {
        m_Board = boardManager;
        m_CellPosition = cell;

        // Move the player to the world position of the given cell
        transform.position = m_Board.CellToWorld(cell);
    }
}