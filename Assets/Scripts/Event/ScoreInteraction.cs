using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInteraction : Interaction
{
    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);
        interactionMessage = $"최고점수: {bestScore}" ;
        DialogMessage = "난 15점이 최고점수야!";
    }
    public override void Interact()
    {
    }

    public override void Dialog()
    {
        EventManager.Instance.ShowDialog(DialogMessage);
    }
}
