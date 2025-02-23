using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class RoboticCat : MonoBehaviour
{
    private PlayerInventoryValue item;

    [SerializeField] private GameObject RobotKucingRusak;
    [SerializeField] private GameObject RobotKucingBenar;

    [Header("Visualize Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("INK JSON")]
    [SerializeField] private TextAsset inkJSON;
    
    private bool playerInRange;
    private bool DialogueStart;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        DialogueStart = false;
        RobotKucingBenar.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && !DialogueStart) { 
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueStart = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);

                RepairRobotCat();
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

    private void RepairRobotCat()
    {
        RobotKucingRusak.transform.position = new Vector3(16, 5, 0);
        RobotKucingBenar.SetActive(true);
    }
}
