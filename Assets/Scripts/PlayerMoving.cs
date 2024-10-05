using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    private float verticalInput;

    [Header("Velocity")]
    [SerializeField]private float upVelocity;    
    [SerializeField]private float velocity;
    [SerializeField] private float upAcceleration;
    [SerializeField] private float acceleration;

    private BulletSpawner bulletSpawner;

    private void Start()
    {
        bulletSpawner = FindObjectOfType<BulletSpawner>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            bulletSpawner.CreateObject();     
    }

    private void FixedUpdate()
    {        
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(velocity, verticalInput * upVelocity * Time.deltaTime, 0);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -29, 24), transform.position.z);

        if (velocity < 1.7)
            VelocityUpdate();      
    }

    private void VelocityUpdate()
    {
        velocity += acceleration * Time.deltaTime;
        upVelocity += upAcceleration * Time.deltaTime;
    }
}
