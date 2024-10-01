using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;
    [SerializeField] private Transform target;
    private Vector3 vel = Vector3.zero;
    private void FixedUpdate(){
        Vector3 target_pos = target.position+ offset;
        transform.position = Vector3.SmoothDamp(transform.position, target_pos, ref vel, damping);
    }
}
