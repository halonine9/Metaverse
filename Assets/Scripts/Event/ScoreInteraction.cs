using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreInteraction : Interaction
{
    private void Start()
    {
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);
        interactionMessage = $"최고점수: {bestScore}" ;
    }
    public override void Interact()
    {
    }
}
