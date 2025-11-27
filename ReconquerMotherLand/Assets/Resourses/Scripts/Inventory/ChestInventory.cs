using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChestInventory : InventoryHolder, IInteractable
{
    public void Interact(Interactor interactor, out bool interactionSuccess)
    {
        OnDynamicInventoryDisplayRequest?.Invoke(inventorySystem);
        interactionSuccess = true;
    }

    public void EndInteraction()
    {
    }

    public bool HasInteracted(Interactor interactor)
    {
        return false;
    }
}
