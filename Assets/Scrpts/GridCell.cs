using UnityEngine;
using UnityEngine.UI;

public class GridCell : MonoBehaviour
{
    private Button button;
    private enum CellState { Empty, Filled, Marked }
    private CellState cellState;

    public bool isFilled
    {
        get { return cellState == CellState.Filled; }
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnCellLeftClicked);
        cellState = CellState.Empty;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            OnCellRightClicked();
        }
    }

    void OnCellLeftClicked()
    {
        if (cellState == CellState.Empty)
        {
            cellState = CellState.Filled;
        }
        else if (cellState == CellState.Filled)
        {
            cellState = CellState.Empty;
        }
        UpdateCellAppearance();
    }

    void OnCellRightClicked()
    {
        if (cellState == CellState.Empty)
        {
            cellState = CellState.Marked;
        }
        else if (cellState == CellState.Marked)
        {
            cellState = CellState.Empty;
        }
        UpdateCellAppearance();
    }

    void UpdateCellAppearance()
    {
        switch (cellState)
        {
            case CellState.Empty:
                button.image.color = Color.white;
                break;
            case CellState.Filled:
                button.image.color = Color.black;
                break;
            case CellState.Marked:
                button.image.color = Color.red;
                break;
        }
    }
}
