using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : Interaction
{
    private void Start()
    {
        interactionMessage = "F를 눌러 게임 실행";
    }
    public override void Interact()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MiniGameScene");
    }
}
