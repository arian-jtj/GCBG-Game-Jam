using UnityEngine;

public class BeaconButtonPrompt : MonoBehaviour
{
    [SerializeField] private GameObject beaconSingleButton;
    [SerializeField] private GameObject beaconDoubleButtons;
    [SerializeField] private PlayerWorldHistory currentPlayerWorldHistory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision Enter");
        if(collision.gameObject.CompareTag("Player"))
        {
            if(currentPlayerWorldHistory.hadBeenToWorld2 && currentPlayerWorldHistory.hadBeenToWorld3)
            {
                beaconDoubleButtons.SetActive(true);
            }
            else
            {
                beaconSingleButton.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Collision Exit");
        if(collision.gameObject.CompareTag("Player"))
        {
            beaconDoubleButtons.SetActive(false);
            beaconSingleButton.SetActive(false);
        }
    }
}
