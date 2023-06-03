using UnityEngine;

public class ItemController :MonoBehaviour
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private int amount;

    public ItemSO GetItemSO()
    {
        return itemSO;
    }

    public void Pickup()
    {
        InventoryManager.Instance.AddItem(itemSO);
        Destroy(gameObject);
    }

    public void UseItem()
    {
        amount--;

        switch(itemSO.itemType)
        {
            case ItemSO.ItemType.Food:
                //
                break;



        }

    }

    public void DeleteObjAfterUse()
    {
        if(amount == 0)
        {
            InventoryManager.Instance.Remove(itemSO);
        }
    }
}
