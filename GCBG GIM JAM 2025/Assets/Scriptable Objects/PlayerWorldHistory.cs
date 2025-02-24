using UnityEngine;

[CreateAssetMenu(fileName = "PlayerWorldHistory", menuName = "Scriptable Objects/PlayerWorldHistory")]
public class PlayerWorldHistory : ScriptableObject
{
    [SerializeField] private bool valueOnReset;
    [SerializeField] private int counterValueOnReset;

    public bool hadBeenToWorld2;
    public bool hadBeenToWorld3;

    public int worldHoppingCounter;

    private void OnEnable()
    {
        hadBeenToWorld2 = valueOnReset;
        hadBeenToWorld3 = valueOnReset;
        worldHoppingCounter = counterValueOnReset;
    }
}
