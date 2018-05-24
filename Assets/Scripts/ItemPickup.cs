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
        //Add Item to inventory 
        Destroy(gameObject);
    }
}
