using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Player movement speed
    public float rotationSpeed = 5.0f; // Player rotation speed
    private CharacterController characterController;
    public Rigidbody Rigidbody;
    public Animator animator;

    // Define input names
    public string inputNameHorizontal;
    public string inputNameVertical;
    private float inputHorizontal;
    private float inputVertical;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Get input for player movement
         inputHorizontal = Input.GetAxis(inputNameHorizontal);
         inputVertical = Input.GetAxis(inputNameVertical);

        // Calculate movement direction based on input
        Vector3 moveDirection = new Vector3(inputHorizontal, 0, inputVertical);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;


        // Apply gravity
        moveDirection.y -= 9.81f * Time.deltaTime;

        // Move the player
        characterController.Move(moveDirection * Time.deltaTime);

        // Rotate the player based on mouse input
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.Rotate(Vector3.up * mouseX);

        animator.SetFloat(inputNameHorizontal, inputHorizontal);
        animator.SetFloat(inputNameVertical, inputVertical);
    }
}
