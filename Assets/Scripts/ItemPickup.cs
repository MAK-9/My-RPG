using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up "+item.name);
        //add to inventory
        if (Inventory.instance.Add(item))
        {
            //remove from scene
            Destroy(gameObject);
        }
        
        
    }
}
