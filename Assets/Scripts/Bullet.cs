using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float velocity;

    private Rigidbody2D rb;
    private bool isRigidBody2d;

    private void Start()
    {
        isRigidBody2d = TryGetComponent<Rigidbody2D>(out rb);
    }

    private void FixedUpdate()
    {
        if (isRigidBody2d) 
            rb.AddForce(new Vector2(velocity, 0));
    }
}
