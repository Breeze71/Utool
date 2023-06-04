using UnityEngine;


public abstract class ItemSO : ScriptableObject
{
    public enum ItemType
    {
        Food,
        Equipment, 
        Potion, 
        Money,
        Default,
    }
    public string itemName;
    public Sprite sprite;
    public Transform prefab;
    public ItemType itemType;

    [TextArea(15, 20)]
    public string description;
}
