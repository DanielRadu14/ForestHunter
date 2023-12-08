using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class Interacter : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionPointRadius;
    [SerializeField] private LayerMask interactableMask;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] private int numFound;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position,
            interactionPointRadius, colliders, interactableMask);

        if(numFound > 0)
        {
            var interactable = colliders[0].GetComponent<IInteractable>();

            //if(interactable != null && Keyboard.current.)
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPointRadius);
    }
}