using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public static Movement2 instance;
    // public float accelerationFactor = 30.0f;
    public float accelerationFactor = 300.0f;
    public float driftFactor = 0.95f;
    public float turnFactor = 3.5f;


    float accelerationInput = 0;
    float steeringInput = 0;
    float rotaionAngle = 0;
    // Start is called before the first frame update

    Rigidbody2D playerRigidbody2D;


    void Awake()
    {
        instance = this;
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        steeringInput = Input.GetAxis(InputAxes.Player2_xDir);
        accelerationInput = Input.GetAxis(InputAxes.Player2_yDir);
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

    public void Increase_P2_Speed()
    {
        accelerationFactor *= 2;
    }
}
