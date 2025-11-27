using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SphereCollider))]
public class WeaponEquip : MonoBehaviour, IInteractable
{
    [SerializeField] private float rotationSpeed = 20;
    [SerializeField] WeaponData weaponData;

    private SphereCollider myCollider;
    public float pickupRadius = 1;


    private void Awake()
    {
        myCollider = GetComponent<SphereCollider>();
        myCollider.isTrigger = true;
        myCollider.radius = pickupRadius;
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    public UnityAction<IInteractable> onInteractionComplete { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }


    private void OnTriggerEnter(Collider other)
    {
        /*if (other.CompareTag("Player"))
        {
            RightHand rightHand = other.GetComponent<PlayerScpt>().RightHand;

            rightHand.SetSword(weaponData);
            Destroy(gameObject);
        }*/
    }

    public void Interact(Interactor interactor, out bool interactionSuccess)
    {
        throw new System.NotImplementedException();
    }

    public void EndInteraction()
    {
        throw new System.NotImplementedException();
    }

    public void HasInteracted(Interactor interactor, out bool hasInteracted)
    {
        throw new System.NotImplementedException();
    }
}
