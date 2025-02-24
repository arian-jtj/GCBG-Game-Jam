using UnityEngine;

public class BeaconController : MonoBehaviour
{
    [SerializeField] private GameObject sceneTransition;
    private SceneTransitionManager sceneTransitionManager;
    [SerializeField] private PlayerWorldHistory currentPlayerWorldHistory;

    [Header("Where To (checklist one if needed)")]
    [SerializeField] private bool toWorld2;
    [SerializeField] private bool toWorld3;

    void Start()
    {
        sceneTransitionManager = sceneTransition.GetComponent<SceneTransitionManager>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Beacon Button Clicked");

        if(toWorld2)
        {
            currentPlayerWorldHistory.hadBeenToWorld2 = true;
        }

        if(toWorld3)
        {
            currentPlayerWorldHistory.hadBeenToWorld3 = true;
        }

        if(currentPlayerWorldHistory.hadBeenToWorld2 && currentPlayerWorldHistory.hadBeenToWorld3)
        {
            currentPlayerWorldHistory.worldHoppingCounter++;
        }
        
        sceneTransitionManager.ChangeScene();
    }
}
