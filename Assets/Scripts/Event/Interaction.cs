using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interaction : MonoBehaviour
{
    public string interactionMessage = "상호작용 메세지";
    protected bool playerInRange = false;
    protected virtual void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            Interact();
        }
        
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
           EventManager.Instance.ShowInteraction(interactionMessage, transform);
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
           EventManager.Instance.HideInteraction();
        }
    }

    public abstract void Interact();
}
