using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_2 : MonoBehaviour
{
    public Rigidbody2D p1;
    public float p1Speed=5f;
    public float turnSpeed=5f;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotate=Input.GetAxis(InputAxes.Player1_xDir);
        movement.x=0;
        movement.y=Input.GetAxis(InputAxes.Player1_yDir);
        float turn=rotate*turnSpeed*Time.deltaTime;
        transform.Rotate(0,0,turn,Space.World);
    }

    void FixedUpdate()
    {
        p1.MovePosition(p1.position+movement*p1Speed*Time.fixedDeltaTime);
        
    }
}
