using UnityEngine;


public class WalkingController : MonoBehaviour
{
    private bool isWalking = false;

    public float moveSpeed = 5.0f; // Player movement speed
    public float rotationSpeed = 5.0f; // Player rotation speed
    private CharacterController characterController;
    //public Rigidbody Rigidbody;
    public Animator animator;

   
        private void Start()
        {
            characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {

        if (isWalking)
        {
            // Get input for movement
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // Calculate movement direction
            Vector3 movement = new Vector3(horizontal, 0f, vertical);
            movement = Vector3.ClampMagnitude(movement, 1f);

            // Convert input to world space
            movement = transform.TransformDirection(movement);

            // Apply movement
            characterController.SimpleMove(movement * moveSpeed);
        }

        //// Get input for player movement
        //float horizontalInput = Input.GetAxis("horizontalInput");
        //    float verticalInput = Input.GetAxis("verticalInput");

        //    // Calculate movement direction based on input
        //    Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);

        //    moveDirection = transform.TransformDirection(moveDirection);
        //    moveDirection *= moveSpeed;

        //    // Apply gravity
        //    moveDirection.y -= 9.81f * Time.deltaTime;

        //// Move the player
        //characterController.Move(moveDirection * Time.deltaTime);

        //    // Rotate the player based on mouse input
        //    float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        //    transform.Rotate(Vector3.up * mouseX);

        //    animator.SetFloat("horizontalInput", horizontalInput);
        //    animator.SetFloat("verticalInput", verticalInput);
        }
    public void StartWalking()
    {
        isWalking = true;
        // You can add any specific behavior or animations for walking here.
    }
}
