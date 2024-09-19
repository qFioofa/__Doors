using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard_input_handler : MonoBehaviour {
    public float move_speed;
    private bool is_moving;
    private Vector2 input;
    private Vector3 target_pos;

    private void Update(){
        if(is_moving) return;

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        if(input == Vector2.zero) return;
        target_pos = transform.position;
        target_pos.x += input.x;
        target_pos.y += input.y;

        StartCoroutine(Move(target_pos));
    }

    IEnumerator Move(Vector3 target_position){
        is_moving = true;
        while((target_position - transform.position).sqrMagnitude > Mathf.Epsilon){
            transform.position = Vector3.MoveTowards(transform.position, target_position, move_speed * Time.deltaTime);
            yield return null;
        }
        transform.position = target_position;
        is_moving = false;
    }
}
