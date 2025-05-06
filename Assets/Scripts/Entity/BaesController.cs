using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaesController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    [SerializeField] protected SpriteRenderer characterRenderer;
    [Range(1f, 20f)] [SerializeField] private float speed = 5;

    public float Speed
    {
        get => speed;
        set => speed = Mathf.Clamp(value, 0, 20);
    }

    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection { get { return movementDirection; }}
    
    protected AnimationHandler animationHandler;
    
    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animationHandler = GetComponent<AnimationHandler>();
    }
    protected virtual void Update()
    {
        Action();
    }
    
    protected virtual void FixedUpdate()
    {
        Movment(movementDirection);
    }
    
    protected virtual void Action()
    {
        
    }
    
    private void Movment(Vector2 direction)
    {
        direction = direction * Speed;
        _rigidbody.velocity = direction;
        animationHandler.Move(direction);
    }
    
}
