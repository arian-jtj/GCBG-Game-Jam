using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InjuredMan : MonoBehaviour
{
    private PlayerInventoryValue item;

    [SerializeField] private GameObject InjuredNPC;

    [Header("Visualize Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON1;
    [SerializeField] private TextAsset inkJSON2;

    private bool playerInRange;
    private bool DialogueStart;
    private string minigameResult = "";
    //private hasilminigame;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        DialogueStart = false;
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !DialogueStart)
        {
            visualCue.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (string.IsNullOrEmpty(minigameResult))
                {
                    //StartMinigame();
                }
                else
                {
                    switch (minigameResult)
                    {
                        case "sunflower":
                            DialogueManager.GetInstance().EnterDialogueMode(inkJSON1);
                            item.haveRedCard = true;
                            break;
                        case "fourleaf":
                            DialogueManager.GetInstance().EnterDialogueMode(inkJSON2);
                            item.haveBlueCard = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
