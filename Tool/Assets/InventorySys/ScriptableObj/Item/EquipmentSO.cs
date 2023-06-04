using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Inventory System/Item/Equipment")]
public class EquipmentSO : ItemSO
{
    public float attackBonus;
    public float defenceBouns;
    private void Awake() 
    {
        itemType = ItemType.Equipment;
    }
}
