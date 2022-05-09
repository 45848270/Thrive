using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class P1InputValues : MonoBehaviour
{
    private PlayerControlls input;
    private InputAction movement;
    private InputAction direction;
    public Movement mover;


    private void Awake()
    {
       input= new PlayerControlls();
       //mover=GetComponent<Movement>();
    }

    private void OnEnable()
    {
        movement=input.Player.Movement;
        direction=input.Player.Direction;
        movement.Enable();
        direction.Enable();

        input.Player.Fire.performed += OnFire;
        input.Player.Fire.Enable();
       // input.Player.Movement.canceled += OnMove;
    }

    private void OnFire(InputAction.CallbackContext obj)
    {
        Debug.Log("Fire");
    }

    private void OnDisable()
    {
        movement.Disable();
        direction.Disable();
        input.Player.Fire.Disable();
    }

    // Start is called before the first frame update

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Debug.Log("Movement  "+ movement.ReadValue<float>());
        mover.SetVerticalMovement(movement.ReadValue<float>());
        mover.SetHorizontalMovement(direction.ReadValue<float>());
    }
}
