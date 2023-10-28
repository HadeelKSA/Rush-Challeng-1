using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class SkydivingController : MonoBehaviour
{
    private GameManagerScript GMS;

    //private Vector3 moveDirection = Vector3.zero;
    //private Vector2 inputVector = Vector2.zero;


    //input system
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    //public void SetInputVector(Vector2 direction)
    //{
    //    inputVector = direction;
    //}

    // public PlayerInputAction playerControls;
    //// Vector3 rot = Vector3.zero;
    // private InputAction move;
    // private InputAction fire;


    // private void OnEnable()
    // {
    //     move = playerControls.Player.Move;
    //     move.Enable();

    //     fire = playerControls.Player.Fire;
    //     fire.Enable();
    //     fire.performed += Fire;
    //         }

    // private void OnDisable()
    // {
    //     move.Disable();
    //     fire.Disable();
    //  }
    //input system

    public float speed = 50f;
   public string inputNameHorizontal;
     public string inputNameVertical;
    private float inputHorizontal;
    private float inputVertical;
    //private Renderer renderer;

    public float drag = 6;

    public Rigidbody rb;

    private Vector3 rot;

    public float percentage;

    private void Start()

    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();

        //  renderer = GetComponentInChildren<Renderer>();
        rb = GetComponent<Rigidbody>();
        rot = transform.eulerAngles;
        rb.velocity = transform.forward * speed;

    }

    private void Update()
    {
        if (GMS.counterDownDone == true)
        {

            inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
            inputVertical = Input.GetAxisRaw(inputNameVertical);


            // Rotate the player
            //x
            rot.x += 20 * inputVertical * Time.deltaTime;
            rot.x = Mathf.Clamp(rot.x, 0, 45);

            //y
            rot.y += 20 * inputHorizontal * Time.deltaTime;

            //
            rot.z = -5 * inputHorizontal;
            rot.z = Mathf.Clamp(rot.z, -5, 5);
            transform.rotation = Quaternion.Euler(rot);

            percentage = rot.x / 45;

            // drag: fast(4), slow(6)
            float mod_drag = (percentage * -2) + 6;
            // speed: fast(13.8), slow(12.5)
            float mod_speed = percentage * (70f - 50f) + 50f;

            rb.drag = mod_drag;
            Vector3 localV = transform.InverseTransformDirection(rb.velocity);
            localV.z = mod_speed;
            rb.velocity = transform.TransformDirection(localV);

        }

    }

    //private void FixedUpdate()
    //{
    //    rb.velocity = new Vector3(inputHorizontal * speed * Time.fixedDeltaTime, rb.velocity.y, inputVertical * speed * Time.fixedDeltaTime);
    //}

}