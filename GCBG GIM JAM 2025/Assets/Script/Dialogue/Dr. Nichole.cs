using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class DrNichole : MonoBehaviour
{
    public PlayerInventoryValue item;

    [SerializeField] private GameObject DrNicholee;

    [Header("Visualize Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] private TextAsset inkJSON1;


    private bool playerInRange;
    private bool DialogueStart;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        DialogueStart = false;
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !DialogueStart && item.haveEarthCore == true && item.haveWrench == true) { 
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !DialogueStart && item.haveEarthCore == false && item.haveWrench == false)
        {
            visualCue.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON1);
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

    private void itemcheck()
    {
        item.haveEarthCore = true;
        item.haveWrench = true;

    }
}
