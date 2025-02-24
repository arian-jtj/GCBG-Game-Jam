using UnityEngine;

public class TestDialogueManual2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] public GameObject DialogButton;
    [SerializeField] private PlayerInventoryValue currentPlayerInventoryValue;

    private void OnMouseDown()
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        currentPlayerInventoryValue.haveZincDust = true;
        DialogButton.SetActive(false);

    }
}
