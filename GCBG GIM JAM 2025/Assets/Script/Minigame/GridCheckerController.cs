using UnityEngine;
using System.Collections.Generic;

public class GridCheckerController : MonoBehaviour
{
    public GameObject gridsParent; // Assign this in the Inspector

    [Header("Grid Checker Corresponding Possibilities")]
    public string possibility1, possibility2, possibility3;

    private bool allPiecesIsPossibility1, allPiecesIsPossibility2, allPiecesIsPossibility3;

    private string[] piecesInGrid = new string[9];

    public void CheckAllGrid()
    {
        // Get all GridController components from children of the gridsParent
        GridController[] gridController = gridsParent.GetComponentsInChildren<GridController>();

        // for(int i = 0; i < gridController.Length; i++)
        // {
        //     piecesInGrid[i] = gridController[i].detectedPieceInGrid;
        //     Debug.Log("Stored Value [" + i + "]: " + piecesInGrid[i]);
        // }

        for(int i = 0; i < gridController.Length; i++)
        {
            if(gridController[i].detectedPieceInGrid == possibility1)
            {

            }
        }
    }
}
