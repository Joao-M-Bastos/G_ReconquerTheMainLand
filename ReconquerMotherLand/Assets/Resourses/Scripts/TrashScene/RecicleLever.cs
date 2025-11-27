using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RecicleLever : MonoBehaviour, IInteractable
{
    [SerializeField] protected Recicler recicler;
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
            interactionSuccess = true;
            recicler.ActivateRecicler();
        }

    }

    public bool HasInteracted(Interactor interactor)
    {
        return recicler.IsActive;
    }
}
