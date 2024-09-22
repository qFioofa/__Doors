using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour{

    [SerializeField]
    public float move_speed = 10;
    private Rigidbody2D rigid_body_2D;
    private Vector2 diraction;

    public InputActionReference move;

    private void Awake(){
        rigid_body_2D = GetComponent<Rigidbody2D>();
    }
    private void Update(){
        diraction = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate(){
        rigid_body_2D.velocity = diraction * move_speed* Time.fixedDeltaTime;
    }
}
