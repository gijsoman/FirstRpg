using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        Instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallback;

    public int space = 20;

    public List<Item> Items = new List<Item>();

    public bool Add(Item item)
    {
        if (!item.IsDefaultItem)
        {
            if (Items.Count >= space)
            {
                Debug.Log("Not enough room");
                return false;
            }
            Items.Add(item);

            if (OnItemChangedCallback != null)
            {
                OnItemChangedCallback.Invoke();
            }
        }
        return true;
    }

    public void Remove(Item item)
    {
        Items.Remove(item);

        if (OnItemChangedCallback != null)
        {
            OnItemChangedCallback.Invoke();
        }
    }
}
