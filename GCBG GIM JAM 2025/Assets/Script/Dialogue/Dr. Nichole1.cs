using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class DrNichole1 : MonoBehaviour
{
    public PlayerInventoryValue item;

    [SerializeField] private GameObject DrNichole;

    [Header("Visualize Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON;
    
    private bool playerInRange;
    private bool DialogueStart;

    public string transitionSceneToMinigame;

    // [SerializeField] private NPCHaveTalked currentNPCHaveTalked;
    // private BoxCollider2D _collider;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        DialogueStart = false;
    }

    // void Start()
    // {
    //     _collider = GetComponent<BoxCollider2D>();
    // }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !DialogueStart) { 
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueStart = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                //add minigame

                StartCoroutine(DrNicholeDead());
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

    IEnumerator DrNicholeDead()
    {
        yield return new WaitForSeconds(10);
        DrNichole.SetActive(false);
        SceneManager.LoadSceneAsync(transitionSceneToMinigame);
    }
        
}
