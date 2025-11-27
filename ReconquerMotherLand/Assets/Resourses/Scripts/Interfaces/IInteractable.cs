using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IInteractable
{
    public void Interact(Interactor interactor, out bool interactionSuccess);

    public void EndInteraction();

    public bool HasInteracted(Interactor interactor);
}
