using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInventoryValue", menuName = "Scriptable Objects/PlayerInventoryValue")]
public class PlayerInventoryValue : ScriptableObject
{
    [SerializeField] private bool valueOnReset;

    [Header("Player Items in Inventory")]
    public bool haveDiary;
    public bool haveLighter;
    public bool haveZincDust;
    public bool haveCompass;
    public bool havePotion;
    public bool haveMedicine;
    public bool haveBlueCard;
    public bool haveRedCard;
    public bool haveGoggles;
    public bool havePaperFromChest;
    public bool haveWrench;
    public bool haveEarthCore;
    public bool haveLastKey;
    public bool haveActivationCard;
    public bool haveGadget;
    public bool haveRubyRing;
    public bool haveOldRadio;

    private void OnEnable()
    {
        haveDiary = valueOnReset;
        haveLighter = valueOnReset;
        haveZincDust = valueOnReset;
        haveCompass = valueOnReset;
        havePotion = valueOnReset;
        haveMedicine = valueOnReset;
        haveBlueCard = valueOnReset;
        haveRedCard = valueOnReset;
        haveGoggles = valueOnReset;
        havePaperFromChest = valueOnReset;
        haveWrench = valueOnReset;
        haveEarthCore = valueOnReset;
        haveLastKey = valueOnReset;
        haveActivationCard = valueOnReset;
        haveGadget = valueOnReset;
        haveRubyRing = valueOnReset;
        haveOldRadio = valueOnReset;
    }
}
