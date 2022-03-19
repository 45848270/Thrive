using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis(InputAxes.Player1_yDir);
        transform.Translate(y * speed * Time.deltaTime * Vector3.up);

        float x = Input.GetAxis(InputAxes.Player1_xDir);
        transform.Translate(x * speed * Time.deltaTime * Vector3.right);

    }
}
