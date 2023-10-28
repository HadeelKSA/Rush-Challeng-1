using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    private bool isGrounded = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
}
