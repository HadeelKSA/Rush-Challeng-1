using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{

    public Animator animator;

    public Transform cameraTransform; // Assign the camera transform in the Inspector
    public float cameraBobSpeed = 2.0f; // Speed of camera bobbing
    public float cameraBobAmount = 0.1f; // Amount of camera bobbing
    private float cameraBobTimer = 0f;

    public string inputNameHorizontal;
    public string inputNameVertical;
    private float inputHorizontal;
    private float inputVertical;

    public float moveSpeed = 5.0f; // Player movement speed
    public float rotationSpeed = 0.5f; // Player rotation speed
    private CharacterController characterController;
    public AudioSource footstepSound;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        footstepSound = GetComponent<AudioSource>();
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
        //float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        //transform.Rotate(Vector3.up * mouseX);

        float rotationInput = inputHorizontal; // You can use a different input axis if needed
        float rotationAmount = rotationInput * rotationSpeed;

        transform.Rotate(Vector3.up * rotationAmount);


        animator.SetFloat("horizontalInput", inputHorizontal);
        animator.SetFloat("verticalInput", inputVertical);

        // Play walking sound when moving

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            footstepSound.enabled = true;
        }


        else
        {
            footstepSound.enabled = false;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            cameraBobTimer += Time.deltaTime * cameraBobSpeed;
            cameraTransform.localPosition = new Vector3(0, Mathf.Sin(cameraBobTimer) * cameraBobAmount, 0);
        }
        else
        {
            cameraBobTimer = 0;
            cameraTransform.localPosition = Vector3.zero;
        }

    } 
}