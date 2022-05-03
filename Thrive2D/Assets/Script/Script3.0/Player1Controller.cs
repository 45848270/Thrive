using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1Controller : MonoBehaviour
{
    float speed;
    Vector2 moveValue;
    
    public void Move(InputAction.CallbackContext context)
    {
        moveValue=context.ReadValue<Vector2>()*Time.deltaTime*speed;
    }

    private void Update()
    {
        transform.Translate(moveValue);
    }
}
