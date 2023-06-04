using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ItemDatabaseSO : ScriptableObject, ISerializationCallbackReceiver
{
    public ItemSO[] itemSOList;
    public Dictionary<ItemSO, int> GetID_From_ItemSO = new Dictionary<ItemSO, int>();
    public Dictionary<int, ItemSO> GetItemSO_From_ID = new Dictionary<int, ItemSO>();

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        //GetID_From_ItemSO = new
    }

    void ISerializationCallbackReceiver.OnBeforeSerialize()
    {

    }
}
