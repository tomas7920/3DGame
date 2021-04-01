using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEnemy : Interactable
{
    protected override void Interact()
    {
        base.Interact();
        Debug.Log("Let`s fight, dude");
    }
}
