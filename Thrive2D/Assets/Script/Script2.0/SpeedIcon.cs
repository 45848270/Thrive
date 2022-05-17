using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIcon : Item
{

    public GameObject psRed;
    public GameObject psBlue;

    void OnTriggerEnter2D(Collider2D SpeedIncrease)
    {
        
         if (SpeedIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(SpeedIncrease.gameObject);
            Instantiate(psRed,transform.position,Quaternion.identity);
            Destroy(gameObject);
            Movement.instance.Increase_P1_Speed();                                                                   
        }
        if (SpeedIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(SpeedIncrease.gameObject);
            Instantiate(psBlue,transform.position,Quaternion.identity);
            Destroy(gameObject);
            Movement2.instance.Increase_P2_Speed();                                                                   
        }
    }
}
