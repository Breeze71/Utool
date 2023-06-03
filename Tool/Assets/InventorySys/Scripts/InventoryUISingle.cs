using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUISingle : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private Image icon;

    public void SetItemSO_Property(ItemSO itemSO)
    {
        icon.sprite = itemSO.sprite;
        //itemName.text = itemSO.objName;
    }
}
