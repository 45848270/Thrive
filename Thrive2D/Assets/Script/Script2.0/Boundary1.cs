using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary1 : MonoBehaviour
{

    public float zoneTimer=60;
    private float x;
    private float y;

    private float timer;
    

     // Start is called before the first frame update
    void Start()
    {
        timer=0;
         y=4.5f;       //InputAxes.screenHeight/2;
         x=9;            //InputAxes.screenWidth/2;
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
       if(timer>=0)
       {
           transform.position = new Vector2(Mathf.Clamp(transform.position.x, -x, x), Mathf.Clamp(transform.position.y, -y, y));
       }
       else 
       {
           if(timer>zoneTimer)
           {
             transform.position = new Vector2(Mathf.Clamp(transform.position.x, -x+2, x-2), Mathf.Clamp(transform.position.y, -y+2, y-2));  
           }
       }
       timer+=Time.deltaTime;
       
    }
}
