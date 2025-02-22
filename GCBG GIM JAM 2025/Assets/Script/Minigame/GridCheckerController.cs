using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class GridCheckerController : MonoBehaviour
{
    public GameObject gridsParent; // Assign this in the Inspector

    // [Header("Grid Checker Corresponding Possibilities")]
    // public string possibility1;
    // public string possibility2;
    // public string possibility3;

    private bool allPiecesIsPossibility1 = false;
    private bool allPiecesIsPossibility2 = false;
    private bool allPiecesIsPossibility3 = false;

    // private string[] piecesInGrid = new string[9];
    // private bool[] areGridsEmpty = new bool[9];

    [Header("Possible Piece Combinations")]
    public string[] possibility1Checklist = new string[9];
    public string[] possibility2Checklist = new string[9];
    public string[] possibility3Checklist = new string[9];

    // public void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.E))
    //     {
    //         CheckAllGrid();
    //     }
    // }

    public void CheckAllGrid()
    {
        // Get all GridController components from children of the gridsParent
        GridController[] gridController = gridsParent.GetComponentsInChildren<GridController>();

        // for(int i = 0; i < gridController.Length; i++)
        // {
        //     if(gridController[i].isGridEmpty == false)
        //     {
        //         piecesInGrid[i] = gridController[i].detectedPieceInGrid;
        //     }
        //     else if(gridController[i].isGridEmpty == true)
        //     {
        //         piecesInGrid[i] = null;
        //     }
        //     // areGridsEmpty[i] = gridController[i].isGridEmpty;
        //     // Debug.Log("Piece in grid [" + i + "]: " + piecesInGrid[i]);
        //     // Debug.Log("Is grid empty [" + i + "]: " + areGridsEmpty[i]);
        // }

        Debug.Log("Possibility 1 Checklist");
        for(int i = 0; i < gridController.Length; i++)
        {
            if(gridController[i].detectedPieceInGrid == possibility1Checklist[i])
            {
                Debug.Log(gridController[i].detectedPieceInGrid + " == " + possibility1Checklist[i]);
                allPiecesIsPossibility1 = true;
            }
            else
            {
                Debug.Log(gridController[i].detectedPieceInGrid + " == " + possibility1Checklist[i]);
                allPiecesIsPossibility1 = false;
                break;
            }
        }

        Debug.Log("Possibility 2 Checklist");
        for(int i = 0; i < gridController.Length; i++)
        {
            if(gridController[i].detectedPieceInGrid == possibility2Checklist[i])
            {
                Debug.Log(gridController[i].detectedPieceInGrid + " == " + possibility2Checklist[i]);
                allPiecesIsPossibility2 = true;
            }
            else
            {
                Debug.Log(gridController[i].detectedPieceInGrid + " == " + possibility2Checklist[i]);
                allPiecesIsPossibility2 = false;
                break;
            }
        }

        Debug.Log("Possibility 3 Checklist");
        for(int i = 0; i < gridController.Length; i++)
        {
            if(gridController[i].detectedPieceInGrid == possibility3Checklist[i])
            {
                Debug.Log(gridController[i].detectedPieceInGrid + " == " + possibility3Checklist[i]);
                allPiecesIsPossibility3 = true;
            }
            else
            {
                Debug.Log(gridController[i].detectedPieceInGrid + " == " + possibility3Checklist[i]);
                allPiecesIsPossibility3 = false;
                break;
            }
        }

        // // Check if all pieces is possibility1
        // for(int i = 0; i < gridController.Length; i++)
        // {
        //     if(gridController[i].detectedPieceInGrid == possibility1)
        //     {
        //         allPiecesIsPossibility1 = true;
        //     }
        //     else if(gridController[i].detectedPieceInGrid == possibility2 || gridController[i].detectedPieceInGrid == possibility3)
        //     {
        //         allPiecesIsPossibility1 = false;
        //         break;
        //     }
        // }

        // // Check if all pieces is possibility2
        // for(int i = 0; i < gridController.Length; i++)
        // {
        //     if(gridController[i].detectedPieceInGrid == possibility2)
        //     {
        //         allPiecesIsPossibility2 = true;
        //     }
        //     else if(gridController[i].detectedPieceInGrid == possibility1 || gridController[i].detectedPieceInGrid == possibility3)
        //     {
        //         allPiecesIsPossibility2 = false;
        //         break;
        //     }
        // }

        // // Check if all pieces is possibility3
        // for(int i = 0; i < gridController.Length; i++)
        // {
        //     if(gridController[i].detectedPieceInGrid == possibility3)
        //     {
        //         allPiecesIsPossibility3 = true;
        //     }
        //     else if(gridController[i].detectedPieceInGrid == possibility1 || gridController[i].detectedPieceInGrid == possibility2)
        //     {
        //         allPiecesIsPossibility3 = false;
        //         break;
        //     }
        // }

        Debug.Log("Possibility 1: " + allPiecesIsPossibility1);
        Debug.Log("Possibility 2: " + allPiecesIsPossibility2);
        Debug.Log("Possibility 3: " + allPiecesIsPossibility3);
        if(allPiecesIsPossibility1 && !allPiecesIsPossibility2 && !allPiecesIsPossibility3)
        {
            Debug.Log("Possibility 1");
        }
        else if(!allPiecesIsPossibility1 && allPiecesIsPossibility2 && !allPiecesIsPossibility3)
        {
            Debug.Log("Possibility 2");
        }
        else if(!allPiecesIsPossibility1 && !allPiecesIsPossibility2 && allPiecesIsPossibility3)
        {
            Debug.Log("Possibility 3");
        }
        else
        {
            Debug.Log("Can't continue");
        }
    }
}
