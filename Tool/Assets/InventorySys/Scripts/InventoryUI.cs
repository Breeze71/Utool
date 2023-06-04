using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private InventoryManagerSO playerInventorySO;

    [SerializeField] private Transform ItemContainer;
    [SerializeField] private Transform ItemTemplate;

    private void Awake() 
    {
        ItemTemplate.gameObject.SetActive(false);
    }


    /* Trigger Event Update Icon */
    #region Trigger Event Update Icon
    private void Start() 
    {
        playerInventorySO.OnItemAdd += playerInventorySO_OnItemAdd;
        playerInventorySO.OnItemRemove += playerInventorySO_OnItemRemove;

        UpdateIcon();  
    }
    private void playerInventorySO_OnItemRemove(object sender, EventArgs e)
    {
        UpdateIcon();
    }
    private void playerInventorySO_OnItemAdd(object sender, EventArgs e)
    {
        UpdateIcon();
    }

    #endregion

    private void UpdateIcon()
    {
        // 先刪除再生成
        foreach(Transform child in ItemContainer)
        {
            if(child == ItemContainer)
                continue;

            Destroy(child.gameObject);
        }

        // 取得當前 List 中物件，再將 icon 換成 scriptable 紀錄的
        foreach(InventorySlot inventorySlot in playerInventorySO.GetSlotList())
        {
            Transform itemTransform = Instantiate(ItemTemplate, ItemContainer);
            itemTransform.gameObject.SetActive(true);

            itemTransform.GetComponent<InventoryUISingle>().SetItemSO_Property(inventorySlot);
        }
    }
}
