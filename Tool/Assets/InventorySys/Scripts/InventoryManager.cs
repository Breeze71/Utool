using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    /* Add, Remove Event */
    #region Update Icon Event
    public event EventHandler OnItemAdd;
    public event EventHandler OnItemRemove;
    #endregion


    [SerializeField ] private List<ItemSO> itemSOList = new List<ItemSO>();

    private void Awake() 
    {
        Instance = this;
    }

    public void AddItem(ItemSO itemSO)
    {
        itemSOList.Add(itemSO);

        OnItemAdd?.Invoke(this, EventArgs.Empty);
    }

    public void Remove(ItemSO itemSO)
    {
        itemSOList.Remove(itemSO);

        OnItemRemove?.Invoke(this, EventArgs.Empty);
    }

    public List<ItemSO> GetItemSOList()
    {
        return itemSOList;
    }
}
