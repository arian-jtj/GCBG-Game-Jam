using UnityEngine;

[CreateAssetMenu(fileName = "StateNPC", menuName = "Scriptable Objects/StateNPC")]
public class TalkingStateNPC : ScriptableObject
{
    [SerializeField] private bool valueOnReset;

    [Header("StateNPC")]
    public bool TalkingToDyingWoman;
    public bool TalkingtoHomeless;
    public bool TalkingtoInjuredBoy;
    public bool TalkingtoHaltMutant;
    public bool TalkingtoCat;
    public bool TalkingtoDrNichole;
}
