using UnityEngine;

[CreateAssetMenu(fileName = "NPCHaveTalked", menuName = "Scriptable Objects/NPCHaveTalked")]
public class NPCHaveTalked : ScriptableObject
{
    public bool valueOnReset;

    public bool NPC1HaveTalked;
    public bool NPC2HaveTalked;
    public bool NPC3HaveTalked;
    public bool NPC4HaveTalked;
    public bool NPC5HaveTalked;
    public bool NPC6HaveTalked;
    public bool NPC7HaveTalked;
    public bool NPC8HaveTalked;
    public bool NPC9HaveTalked;

    private void OnEnable()
    {
        NPC1HaveTalked = valueOnReset;
        NPC2HaveTalked = valueOnReset;
        NPC3HaveTalked = valueOnReset;
        NPC4HaveTalked = valueOnReset;
        NPC5HaveTalked = valueOnReset;
        NPC6HaveTalked = valueOnReset;
        NPC7HaveTalked = valueOnReset;
        NPC8HaveTalked = valueOnReset;
        NPC9HaveTalked = valueOnReset;
    }
}
