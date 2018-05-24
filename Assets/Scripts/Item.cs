using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string Name = "New Itemn";
    public Sprite ItemIcon = null;
    public bool IsDefaultItem = false;
}
