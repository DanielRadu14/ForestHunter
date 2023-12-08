using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    string GetInteractionPrompt();

    bool Interact(Interacter interacter);
}
