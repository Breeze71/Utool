using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
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
        InventoryManager.Instance.OnItemAdd += InventoryManager_OnItemAdd;
        InventoryManager.Instance.OnItemRemove += InventoryManager_OnItemRemove;

        UpdateIcon();  
    }

    private void InventoryManager_OnItemAdd(object sender, EventArgs e)
    {
        UpdateIcon();
    }
    private void InventoryManager_OnItemRemove(object sender, EventArgs e)
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
        foreach(ItemSO itemSO in InventoryManager.Instance.GetItemSOList())
        {
            Transform itemTransform = Instantiate(ItemTemplate, ItemContainer);
            itemTransform.gameObject.SetActive(true);

            itemTransform.GetComponent<InventoryUISingle>().SetItemSO_Property(itemSO);
        }
    }


    
}
