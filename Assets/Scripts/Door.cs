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
        Debug.Log("Opening door!");
        return true;
    }
}
