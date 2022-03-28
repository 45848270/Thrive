using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        float y= 4.45F; //InputAxes.screenHeight;
        float x= 10; //screenWidth;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -x, x), Mathf.Clamp(transform.position.y, -y, y));
        //Debug.Log(Screen.width);
    }
}
