using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class GridController : MonoBehaviour, IDropHandler
{
    [Header("Grid Corresponding Possibilities")]
    public string possibility1;
    public string possibility2;
    public string possibility3;

    [Header("Grid Properties [Leave Empty]")]
    public string detectedPieceInGrid = "0";

    public bool isGridEmpty = true;

    void OnTriggerStay2D(Collider2D collision)
    {
        isGridEmpty = false;
        detectedPieceInGrid = collision.GetComponent<PieceController>().pieceName;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        isGridEmpty = true;
        detectedPieceInGrid = "0";
    }

    // Dropping anything from pointer
    public void OnDrop(PointerEventData eventData)
    {
        // If the pointer is dropping something
        if(eventData.pointerDrag != null)
        {
            // If it's the correct piece that is dropped
            // if(eventData.pointerDrag.GetComponent<PieceController>().pieceName == possibility1 || eventData.pointerDrag.GetComponent<PieceController>().pieceName == possibility2 || eventData.pointerDrag.GetComponent<PieceController>().pieceName == possibility3)
            // {
                detectedPieceInGrid = eventData.pointerDrag.GetComponent<PieceController>().pieceName;
                // Debug.Log(detectedPieceInGrid);
            // }
            // else
            // {
            //     // Debug.Log("False");
            // }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
