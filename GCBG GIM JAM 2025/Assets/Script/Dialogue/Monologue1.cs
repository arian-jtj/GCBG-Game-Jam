using UnityEngine;
using UnityEngine.InputSystem;

public class Monologue1 : MonoBehaviour
{
    [SerializeField] private GameObject Monologue;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;
    private bool dialogueStarted; // Cegah dialog diulang terus-menerus

    private void Awake()
    {
        playerInRange = false;
        dialogueStarted = false;
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !dialogueStarted)
        {
            dialogueStarted = true; // Cegah dialog diulang
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
