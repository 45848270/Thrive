using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIcon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D SpeedIncrease)
    {
        
         if (SpeedIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Movement.instance.Increase_P1_Speed();                                                                   
        }
        if (SpeedIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(gameObject);
            Movement2.instance.Increase_P2_Speed();                                                                   
        }
    }
}
