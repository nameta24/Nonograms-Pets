using UnityEngine;

public class NonogramPuzzle : MonoBehaviour
{
    public NonogramGrid nonogramGrid;
    private int[,] solution = new int[10, 10]
    {
        { 1, 1, 0, 0, 0, 1, 1, 1, 1, 1 },
        { 0, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
        { 1, 0, 0, 0, 1, 1, 0, 0, 1, 0 },
        { 1, 1, 0, 0, 1, 0, 0, 1, 0, 0 },
        { 0, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
        { 0, 1, 1, 0, 0, 1, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 0, 1, 0, 0, 1, 0 },
        { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 },
        { 0, 1, 0, 0, 1, 0, 0, 0, 0, 1 },
        { 1, 0, 0, 0, 1, 1, 1, 0, 1, 0 }
    };

    public void CheckSolution()
    {
        bool isCorrect = true;
        for (int y = 0; y < solution.GetLength(0); y++)
        {
            for (int x = 0; x < solution.GetLength(1); x++)
            {
                GridCell cell = nonogramGrid.gridCells[y, x].GetComponent<GridCell>();
                if ((solution[y, x] == 1 && !cell.isFilled) || (solution[y, x] == 0 && cell.isFilled))
                {
                    isCorrect = false;
                    break;
                }
            }
        }

        if (isCorrect)
        {
            Debug.Log("Puzzle Solved!");
            // Add more feedback or transition to a new puzzle
        }
        else
        {
            Debug.Log("Incorrect Solution");
        }
    }
}
