using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string prompt;

    public string GetInteractionPrompt()
    {
        return prompt;
    }

    public bool Interact(Interacter interacter)
    {
        var inventory = interacter.GetComponent<Inventory>();

        if (inventory == null)
            return false;

        if(inventory.hasKey)
        {
            Debug.Log("Opening door!");
            return true;
        }

        Debug.Log("No key found!");
        return false;

    }
}
