using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public static Movement instance;
    public float accelerationFactor = 50.0f;
    public float driftFactor = 0.95f;
    public float turnFactor = 3.5f;

    Vector2 moveValue;


    float accelerationInput = 0;
    float steeringInput = 0;
    float rotaionAngle = 0;
    // Start is called before the first frame update

    private Rigidbody2D playerRigidbody2D;


    void Awake()
    {
        instance = this;
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }   

    public void Moves(InputAction.CallbackContext context)
    {
        moveValue = context.ReadValue<Vector2>();
    }



    // Update is called once per frame
    void Update()
    {
        // steeringInput = Input.GetAxis(InputAxes.Player1_xDir);
        // accelerationInput = Input.GetAxis(InputAxes.Player1_yDir);

        steeringInput = moveValue.x;
        accelerationInput = moveValue.y;

    }

    void FixedUpdate()
    {
        ApplyEngineForce();
        KillVelocity();
        ApplySteering();
    }
    public void ApplyEngineForce()
    {
        if (accelerationFactor>=400)
        {
            accelerationFactor=400;
        }
        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        playerRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }
    void ApplySteering()
    {
        rotaionAngle -= steeringInput * turnFactor;
        playerRigidbody2D.MoveRotation(rotaionAngle);

    }

    void KillVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(playerRigidbody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(playerRigidbody2D.velocity, transform.right);

        playerRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    public void Increase_P1_Speed()
    {
        accelerationFactor += 30;
    }
}
