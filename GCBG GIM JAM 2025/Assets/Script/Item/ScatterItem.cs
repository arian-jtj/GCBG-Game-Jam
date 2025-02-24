using Unity.VisualScripting;
using UnityEngine;

public class ScatterItem : MonoBehaviour
{
    public GameObject item;
    private bool playerInRange;
    public PlayerInventoryValue value;


    [Header("Visualize Cue")]
    [SerializeField] private GameObject visualCue;

    private void Start()
    {
        item.SetActive(true);
        playerInRange = false;
    }

    private void Update()
    {
        if(playerInRange)
        {
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                item.SetActive(false);
                value.haveWrench = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

}
