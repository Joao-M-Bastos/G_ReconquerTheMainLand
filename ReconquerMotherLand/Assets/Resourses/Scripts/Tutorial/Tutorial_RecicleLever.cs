using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Tutorial_RecicleLever : MonoBehaviour, IInteractable
{
    [SerializeField] protected GameObject canvasObj;
    [SerializeField] protected ReciclerTutorial recicler;
    protected Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void EndInteraction()
    {

    }

    virtual public void Interact(Interactor interactor, out bool interactionSuccess)
    {
        interactionSuccess = false;
        if (!recicler.IsActive)
        {
            animator.SetTrigger("Open");
            canvasObj.SetActive(false);
            interactionSuccess = true;
            recicler.ActivateRecicler();
        }

    }

    public bool HasInteracted(Interactor interactor)
    {
        return recicler.IsActive;
    }
}
