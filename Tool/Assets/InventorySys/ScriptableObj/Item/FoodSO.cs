using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "Inventory System/Item/Food")]
public class FoodSO : ItemSO
{
    public float restoreHealthValue;

    private void Awake()
    {
        itemType = ItemType.Food;
    }

}
