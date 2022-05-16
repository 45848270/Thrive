using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed;
    Vector2 moveValue;

    public void Moves(InputAction.CallbackContext context)
    {
        moveValue = context.ReadValue<Vector2>() * Time.deltaTime * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveValue);
    }
}
