using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletBehavior : MonoBehaviour{
    [SerializeField] private Vector3 Direction_;
    public Vector3 Direction{
        get { return Direction_; }
        set { Direction_ = value; }
    }
    [SerializeField] private float speed = 200f;
    private Rigidbody2D rigidBody2D;
    private void Awake(){
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        this.Move();
    }

    public virtual void Move(){
        rigidBody2D.velocity = Direction_ * speed;
    }

    public void BulletDestroy(float Time){
        Destroy(gameObject,Time);
    }

    public void BulletDestroy(){
        Destroy(gameObject);
    }
}
