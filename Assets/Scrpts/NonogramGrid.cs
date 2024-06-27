using UnityEngine;
using UnityEngine.UI;

public class NonogramGrid : MonoBehaviour
{
    public GameObject gridCellPrefab;
    public int rows = 10;
    public int columns = 10;
    [HideInInspector]
    public GameObject[,] gridCells;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        gridCells = new GameObject[rows, columns];

        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < columns; x++)
            {
                GameObject newCell = Instantiate(gridCellPrefab, transform);
                gridCells[y, x] = newCell;
            }
        }
    }
}
