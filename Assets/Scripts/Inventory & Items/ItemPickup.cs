using UnityEngine;

public class ItemPickup : Interactable
{
    public Item ItemObject;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    private void PickUp()
    {
        Debug.Log("Picking Up Object " + ItemObject.name);
        bool wasPickedUp = Inventory.Instance.Add(ItemObject);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
    }
}
