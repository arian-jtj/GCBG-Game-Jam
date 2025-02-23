using UnityEngine;

public class BeaconButtonPrompt : MonoBehaviour
{
    [SerializeField] private GameObject beaconButtons;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision Enter");
        if(collision.gameObject.CompareTag("Player"))
        {
            beaconButtons.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Collision Exit");
        if(collision.gameObject.CompareTag("Player"))
        {
            beaconButtons.SetActive(false);
        }
    }
}
