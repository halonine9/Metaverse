using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaesController
{
    private Camera camera;
    private bool isLeft = false;

    protected override void Start()
    {
        base.Start();
        camera = Camera.main;
    }

    protected override void Action()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertial = Input.GetAxisRaw("Vertical");
        movementDirection = new Vector2(horizontal, vertial).normalized;
        
        if (horizontal != 0f)
        {
            isLeft = horizontal < 0f;
        }
        characterRenderer.flipX = isLeft;
        
    }
}
