using UnityEngine;

public class ItemController :MonoBehaviour
{
    [SerializeField] private ItemSO itemSO;

    public ItemSO GetItemSO()
    {
        return itemSO;
    }
}
