using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class HomelessManDialogue : MonoBehaviour
{
    public PlayerInventoryValue item;

    [SerializeField] private GameObject Homelessman;

    [Header("Visualize Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON;

    [SerializeField] private GameObject dialogue1Button;
    [SerializeField] private GameObject dialogue2Button;


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
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !DialogueStart) { 
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueStart = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                
                StartCoroutine(HomelessmanDead());

                dialogue1Button.SetActive(true);
                dialogue2Button.SetActive(true);
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

    IEnumerator HomelessmanDead()
    {
        yield return new WaitForSeconds(30);
        Homelessman.SetActive(false);
    }
        
}
