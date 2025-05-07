using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public GameObject interactionUI;
    public GameObject DialogUI;
    public Text interactionText;
    public Text DialogText;

    private RectTransform interactionRect;
    private Camera mainCam;
    private Transform Target;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        interactionRect = interactionUI.GetComponent<RectTransform>();
        mainCam = Camera.main;
        
        HideInteraction();
    }

    private void Update()
    {
        if (Target != null)
        {
            Vector3 screenPos = mainCam.WorldToScreenPoint(Target.position);
            interactionRect.position = screenPos;
        }
    }

    public void ShowInteraction(string message, Transform target) 
    {
        interactionText.text = message;
        interactionUI.SetActive(true);
        Target = target;
    }
    public void ShowDialog(string message)
    {
        DialogText.text = message;
        DialogUI.SetActive(true);
        Target = null;
    }
    public void HideInteraction()
    {
        interactionUI.SetActive(false);
        DialogUI.SetActive(false);
    }
    
}
