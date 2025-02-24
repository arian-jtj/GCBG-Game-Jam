
using Unity.VisualScripting;
using UnityEngine;

public class BubukZinc : MonoBehaviour
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
        if (playerInRange)
        {
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                item.SetActive(false);
                value.haveZincDust = true;
            }
        }
    }

}
