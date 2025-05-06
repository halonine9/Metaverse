using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : EventTrigger
{
    public GameObject Closedoor;
    public GameObject Opendoor;
    private bool isOpen = false;

    private void Start()
    {
        Closedoor.SetActive(true);
        Opendoor.SetActive(false);
        interactionMessage = "F를 누르세요";
    }
    
    public override void Interact()
    {
        isOpen = !isOpen;
        Closedoor.SetActive(!isOpen);
        Opendoor.SetActive(isOpen);
    }
}
