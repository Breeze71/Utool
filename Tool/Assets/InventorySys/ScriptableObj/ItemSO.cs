using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ItemSO : ScriptableObject
{
    // public Transform prefab;
    public Sprite sprite;
    public string objName;
    public ItemType itemType;

    public enum ItemType
    {
        Potion, 
        Weapon, 
        Money,
        Food,
    }
}
