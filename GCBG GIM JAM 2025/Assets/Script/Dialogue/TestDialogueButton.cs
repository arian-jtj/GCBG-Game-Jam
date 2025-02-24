using UnityEngine;
using Ink.Parsed;

public class TestDialogueButton : MonoBehaviour
{
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] public GameObject DialogButton;
    [SerializeField] private PlayerInventoryValue currentPlayerInventoryValue;

    private void OnMouseDown()
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        DialogButton.SetActive(false);
    }
}
