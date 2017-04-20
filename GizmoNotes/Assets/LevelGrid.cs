using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour {

    public Color normalColor = Color.white;
    public Color selectedColor = Color.yellow;

    public float gridSize = 1.5f;

    public int row, col;

    public void DrawGridGizmo(int cols, int rows)
    {
        for(int i = 0; i <= cols; i++)
        {
            Gizmos.DrawLine(new Vector3(i * gridSize, 0), new Vector3(gridSize * i, gridSize * rows));
        }
        for (int i = 0; i <= rows; i++)
        {
            Gizmos.DrawLine(new Vector3(0, i * gridSize), new Vector3(cols * gridSize, gridSize * i));
        }
    }

    public void GridFrameGizmo(int cols, int rows)
    {
        Gizmos.DrawLine(Vector3.zero, new Vector3(0, rows*gridSize, 0));
        Gizmos.DrawLine(new Vector3(cols*gridSize,0), new Vector3(cols*gridSize , rows * gridSize, 0));
        Gizmos.DrawLine(Vector3.zero, new Vector3(cols * gridSize, 0));
        Gizmos.DrawLine(new Vector3(0, rows * gridSize, 0), new Vector3(cols * gridSize, rows * gridSize, 0));

    }

    void OnDrawGizmos()
    {
        Gizmos.color = normalColor;
        DrawGridGizmo(col, row);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = selectedColor;
        GridFrameGizmo(col, row);
    }

    public Vector3 WorldToGrid(Vector3 point)
    {
        Vector3 gridPoint = new Vector3
            ((int)point.x / gridSize,
            (int)point.y / gridSize,
            0);
        return gridPoint;       
    }

    public Vector3 GridToWorld(int col, int row)
    {
        Vector3 worldPoint = new Vector3(
            col * gridSize + gridSize / 2,
            row * gridSize + gridSize / 2,
            0);
        return worldPoint;
    }
    
    public bool IsInsideGridBounds(Vector3 point)
    {
        float minX = 0;
        float minY = 0;
        float maxX = gridSize * col;
        float maxY = gridSize * row;

        return (point.x >= minX && point.x <= maxX && point.y >= minY && point.y <= maxY);
    }

    public bool IsInsideGridBounds(int colP, int rowP)
    {
        return (colP >= 0 && colP < col && rowP >= 0 && rowP < row);
    }
}
