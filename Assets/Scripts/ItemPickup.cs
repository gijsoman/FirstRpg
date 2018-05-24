using UnityEngine;

public class ItemPickup : Interactable {
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    private void PickUp()
    {
        Debug.Log("Picking Up Object");
        //Add Item to inventory 
        Destroy(gameObject);
    }
}
