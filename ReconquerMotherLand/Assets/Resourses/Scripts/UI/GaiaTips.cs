using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GaiaTips : MonoBehaviour, IInteractable
{
    DialogueTrigger dialogueTrigger;

    private void Awake()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
    }
    public void EndInteraction()
    {

    }

    public bool HasInteracted(Interactor interactor)
    {
        return false;
    }

    public void Interact(Interactor interactor, out bool interactionSuccess)
    {
        //SetRandomText();
        if (DialogueManager.Instance.InDialog)
        {
            interactionSuccess = false;
            return;
        }
        dialogueTrigger.TriggerDialogueEvent();
        interactionSuccess = true;
    }
}
