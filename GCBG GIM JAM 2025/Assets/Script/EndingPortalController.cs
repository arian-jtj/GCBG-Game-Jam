using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndingPortalController : MonoBehaviour
{
    [SerializeField] private PlayerInventoryValue currentPlayerInventoryValue;
    [SerializeField] private PlayerWorldHistory currentPlayerWorldHistory;

    private bool playerIsInPortal;

    public string transitionSceneToBadEnd;
    public string transitionSceneToNormalEnd;
    public string transitionSceneToTrueEnd;

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
                    ChangeSceneBadEnd();
                }

                // Normal End (Too Many Secrets)
                else if(currentPlayerWorldHistory.worldHoppingCounter == 3 && currentPlayerInventoryValue.haveBlueCard)
                {
                    Debug.Log("Normal End");
                    ChangeSceneNormalEnd();
                }

                // True End (Too Many Victims)
                else if(currentPlayerWorldHistory.worldHoppingCounter <= 2 && currentPlayerInventoryValue.haveBlueCard)
                {
                    Debug.Log("True End");
                    ChangeSceneTrueEnd();
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

    public void ChangeSceneBadEnd()
    {
        StartCoroutine(LoadSceneBadEnd());
    }

    public void ChangeSceneNormalEnd()
    {
        StartCoroutine(LoadSceneNormalEnd());
    }

    public void ChangeSceneTrueEnd()
    {
        StartCoroutine(LoadSceneTrueEnd());
    }

    IEnumerator LoadSceneBadEnd()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(transitionSceneToBadEnd);
    }

    IEnumerator LoadSceneNormalEnd()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(transitionSceneToNormalEnd);
    }

    IEnumerator LoadSceneTrueEnd()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(transitionSceneToTrueEnd);
    }
}
