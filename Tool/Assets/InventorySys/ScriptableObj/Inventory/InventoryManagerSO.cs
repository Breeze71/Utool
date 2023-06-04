using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryManagerSO : ScriptableObject
{
    /* Add, Remove Event */
    #region Update Icon Event
    public event EventHandler OnItemAdd;
    public event EventHandler OnItemRemove;
    #endregion

    [SerializeField] private List<InventorySlot> slotContainer = new List<InventorySlot>();

    public void AddItem(ItemSO _itemSO, int _amount)
    {
        // Increase Amount
        foreach(InventorySlot inventorySlot in slotContainer)
        {
            if(inventorySlot.GetItemSOFromSlot() == _itemSO)
            {
                inventorySlot.IncreaseAmount(_amount);
                OnItemAdd?.Invoke(this, EventArgs.Empty); // trigger event

                return;
            }
        }
        
        // New Item
        slotContainer.Add(new InventorySlot(_itemSO, _amount));
        OnItemAdd?.Invoke(this, EventArgs.Empty); // trigger event
    }




    public List<InventorySlot> GetSlotList()
    {
        return slotContainer;
    }
    public void ClearAll()
    {
        slotContainer.Clear();
    }
}

[System.Serializable]
public class InventorySlot
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private int amount;

    public InventorySlot(ItemSO _itemSO, int _amount)
    {
        this.itemSO = _itemSO;
        this.amount = _amount;
    }

    public ItemSO GetItemSOFromSlot()
    {
        return itemSO;
    }

    public void IncreaseAmount(int value)
    {
        amount += value;
    }

    public int GetSlotAmount()
    {
        return amount;
    }
}
