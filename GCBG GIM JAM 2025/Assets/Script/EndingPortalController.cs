using UnityEngine;

public class EndingPortalController : MonoBehaviour
{
    [SerializeField] private PlayerInventoryValue currentPlayerInventoryValue;
    [SerializeField] private PlayerWorldHistory currentPlayerWorldHistory;

    private bool playerIsInPortal;

    void Update()
    {
        if(playerIsInPortal)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                // Bad End (Too Many Tries)
                if(currentPlayerWorldHistory.worldHoppingCounter >= 4 || currentPlayerInventoryValue.haveRedCard)
                {
                    Debug.Log("Bad End");
                }

                // Normal End (Too Many Secrets)
                else if(currentPlayerWorldHistory.worldHoppingCounter == 3 && currentPlayerInventoryValue.haveBlueCard)
                {
                    Debug.Log("Normal End");
                }

                // True End (Too Many Victims)
                else if(currentPlayerWorldHistory.worldHoppingCounter <= 2 && currentPlayerInventoryValue.haveBlueCard)
                {
                    Debug.Log("True End");
                }

                else
                {
                    Debug.Log("Can't Enter");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision Enter");
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Enter");
            playerIsInPortal = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Collision Exit");
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Exit");
            playerIsInPortal = true;
        }
    }
}
