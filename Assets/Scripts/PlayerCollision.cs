using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Check for collisions with the ground
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Load the new scene when the player touches the ground
            SceneManager.LoadScene("walk play scene");
        }
    }
}
