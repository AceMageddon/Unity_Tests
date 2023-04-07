using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 12f;
    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float gravity = -9.8f;
    public float jumpForce = 1000;
    bool isGrounded;
    Vector3 velocity;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);
        Vector3 move = transform.right * x + transform.forward * z;
        velocity.y += gravity + Time.deltaTime;
        characterController.Move((velocity * Time.deltaTime) / 2);
        characterController.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
        if(isGrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }
    }
}
