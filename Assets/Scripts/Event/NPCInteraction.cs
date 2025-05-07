using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : Interaction
{
    private void Start()
    {
        interactionMessage = "F를 눌러 게임 실행 \nT를 눌러 게임 설명 보기";
        DialogMessage = "마우스 좌클릭 또는 스페이스바 입력으로 게임을 진행 할 수 있어 ";
    }
    public override void Interact()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MiniGameScene");
    }
    public override void Dialog()
    {
        EventManager.Instance.ShowDialog(DialogMessage);
    }
}
