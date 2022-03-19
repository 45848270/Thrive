using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 4f;
    public float Player2Speed;
    // Start is called before the first frame update
    void Start()
    {
        Player2Speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis(InputAxes.Player2_yDir);
        transform.Translate(y * Player2Speed * Time.deltaTime * Vector3.up);

        float x = Input.GetAxis(InputAxes.Player2_xDir);
        transform.Translate(x * Player2Speed * Time.deltaTime * Vector3.right);

    }
}
