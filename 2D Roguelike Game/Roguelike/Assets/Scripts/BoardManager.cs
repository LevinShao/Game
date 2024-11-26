using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardManager : MonoBehaviour
{
    public class CellData
    {
        public bool Passable; // Determines if the cell is passable
    }

    private CellData[,] m_BoardData; // 2D array for board data
    private Tilemap m_Tilemap; // Reference to the Tilemap
    private Grid m_Grid; // Reference to the Grid component

    public int Width; // Board width
    public int Height; // Board height
    public Tile[] GroundTiles; // Array of ground tiles
    public Tile[] WallTiles; // Array of wall tiles
    public PlayerController Player; // Reference to the PlayerController

    // Start is called before the first frame update
    void Start()
    {
        m_Tilemap = GetComponentInChildren<Tilemap>();
        m_Grid = GetComponentInChildren<Grid>();

        // Initialize the m_BoardData array with board dimensions
        m_BoardData = new CellData[Width, Height];

        for (int y = 0; y < Height; ++y)
        {
            for (int x = 0; x < Width; ++x)
            {
                Tile tile; // Tile to place on the board
                m_BoardData[x, y] = new CellData(); // Initialize CellData

                // Check if the cell is a border
                if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
                {
                    // Use wall tiles for borders
                    tile = WallTiles[Random.Range(0, WallTiles.Length)];
                    m_BoardData[x, y].Passable = false; // Border cells are not passable
                }
                else
                {
                    // Use ground tiles for inner cells
                    tile = GroundTiles[Random.Range(0, GroundTiles.Length)];
                    m_BoardData[x, y].Passable = true; // Inner cells are passable
                }

                // Set the tile on the Tilemap
                m_Tilemap.SetTile(new Vector3Int(x, y, 0), tile);
            }
        }

        // Spawn the player character at a specific cell
        Player.Spawn(this, new Vector2Int(1, 1));
    }

    // Converts a cell index (Vector2Int) to a world position (Vector3)
    public Vector3 CellToWorld(Vector2Int cellIndex)
    {
        return m_Grid.GetCellCenterWorld((Vector3Int)cellIndex);
    }

    public CellData GetCellData(Vector2Int cellIndex)
    {
        if (cellIndex.x < 0 || cellIndex.x >= Width
        || cellIndex.y < 0 || cellIndex.y >= Height)
    {
        return null;
    }

        return m_BoardData[cellIndex.x, cellIndex.y];
    }
}