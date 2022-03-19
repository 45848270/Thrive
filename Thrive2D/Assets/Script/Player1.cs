using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed = 4f;
    public float Player1Speed;
    // Start is called before the first frame update
    void Start()
    {
        Player1Speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis(InputAxes.Player1_yDir);
        transform.Translate(y * Player1Speed * Time.deltaTime * Vector3.up);

        float x = Input.GetAxis(InputAxes.Player1_xDir);
        transform.Translate(x * Player1Speed * Time.deltaTime * Vector3.right);

    }
}
