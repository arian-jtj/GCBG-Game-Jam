using UnityEngine;
using UnityEngine.EventSystems;

public class GridController : MonoBehaviour, IDropHandler
{
    public string correspondingGridPosition;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Dropped");
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.GetComponent<DragAndDrop>().piecePositionInGrid == correspondingGridPosition)
            {
                Debug.Log("Correct");
            }
            else
            {
                Debug.Log("False");
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
