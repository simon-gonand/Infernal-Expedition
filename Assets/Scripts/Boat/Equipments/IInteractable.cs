using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public void InteractWith(PlayerController player);
    public void UninteractWith(PlayerController player);
}
