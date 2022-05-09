using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public static Movement instance;
    // public float accelerationFactor = 30.0f;
    public float accelerationFactor = 300.0f;
    public float driftFactor = 0.95f;
    public float turnFactor = 3.5f;

   // private CharacterController controller;

    float accelerationInput = 0;
    float steeringInput = 0;
    float rotaionAngle = 0;
    // Start is called before the first frame update

    private Rigidbody2D playerRigidbody2D;
    private float xDir=0;
    private float yDir=0;


    void Awake()
    {
        //controller=GetComponent<CharacterController>();
        instance = this;
        
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void SetVerticalMovement(float f)
    {
        yDir=f;
    }
    public void SetHorizontalMovement(float f)
    {
        xDir=f;
    }

    // Update is called once per frame
    void Update()
    {
        steeringInput =xDir;
        accelerationInput = yDir;

    }

    void FixedUpdate()
    {
        ApplyEngineForce();
        KillVelocity();
        ApplySteering();
    }
    void ApplyEngineForce()
    {
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
        accelerationFactor *= 2;
    }
}
