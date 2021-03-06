using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D))]

public class Movement2 : MonoBehaviour
{
    public static Movement2 instance;
    // public float accelerationFactor = 30.0f;
    public float accelerationFactor = 50.0f;
    public float driftFactor = 0.95f;
    public float turnFactor = 3.5f;

    Vector2 moveValue;


    float accelerationInput = 0;
    float steeringInput = 0;
    float rotaionAngle = 0;
    // Start is called before the first frame update

    Rigidbody2D playerRigidbody2D;
    public buffNumUI BuffNumUI;


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
        steeringInput = moveValue.x;
        accelerationInput = moveValue.y;
    }

    void FixedUpdate()
    {
        ApplyEngineForce();
        KillVelocity();
        ApplySteering();
    }
    void ApplyEngineForce()
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

    public void Increase_P2_Speed()
    {
        BuffNumUI.AddSpeedBNum();
        accelerationFactor += 30;
    }
}
