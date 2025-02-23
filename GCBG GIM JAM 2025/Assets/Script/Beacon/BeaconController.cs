using UnityEngine;

public class BeaconController : MonoBehaviour
{
    [SerializeField] private GameObject sceneTransition;
    private SceneTransitionManager sceneTransitionManager;

    void Start()
    {
        sceneTransitionManager = sceneTransition.GetComponent<SceneTransitionManager>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Beacon Button Clicked");
        sceneTransitionManager.ChangeScene();
    }
}
