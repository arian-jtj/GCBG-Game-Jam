using UnityEngine;
using UnityEngine.EventSystems;

public class GridController : MonoBehaviour, IDropHandler
{
    [Header("Grid Corresponding Possibilities")]
    public string possibility1;
    public string possibility2;
    public string possibility3;

    public string detectedPieceInGrid;

    // Dropping anything from pointer
    public void OnDrop(PointerEventData eventData)
    {
        // If the pointer is dragging something
        if(eventData.pointerDrag != null)
        {
            // If it's the correct piece
            if(eventData.pointerDrag.GetComponent<PieceController>().pieceName == possibility1 || eventData.pointerDrag.GetComponent<PieceController>().pieceName == possibility2 || eventData.pointerDrag.GetComponent<PieceController>().pieceName == possibility3)
            {
                detectedPieceInGrid = eventData.pointerDrag.GetComponent<PieceController>().pieceName;
            }
            else
            {
                // Debug.Log("False");
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
