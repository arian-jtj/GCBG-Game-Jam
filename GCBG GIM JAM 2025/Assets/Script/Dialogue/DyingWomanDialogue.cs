using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DyingWomanDialogue: MonoBehaviour
{
    [SerializeField] private GameObject DyingWoman;

    [Header("Visualize Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private bool playerInRange;
    private bool DialogueStart;
    public PlayerInventoryValue item;
    public TalkingStateNPC stateNPC;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        DialogueStart = false;
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !DialogueStart) { 
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueStart = true;
                item.haveCompass = true;
                stateNPC.TalkingToDyingWoman = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);

                StartCoroutine(DyingWomanDead());
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

    IEnumerator DyingWomanDead()
    {
        yield return new WaitForSeconds(30);
        DyingWoman.SetActive(false);
    }
        
}
