using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUISingle : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemAmount;
    [SerializeField] private Image icon;

    public void SetItemSO_Property(InventorySlot slot)
    {
        itemAmount.text = slot.GetSlotAmount().ToString();

        var itemSO = slot.GetItemSOFromSlot();
        icon.sprite = itemSO.sprite;
        itemName.text = itemSO.itemName;
    }
}
