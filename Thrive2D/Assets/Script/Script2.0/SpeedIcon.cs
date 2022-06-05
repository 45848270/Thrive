using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIcon : Item
{

    public GameObject psRed;
    public GameObject psBlue;
    private int speedIconHP=1;

    void OnTriggerEnter2D(Collider2D SpeedIncrease)
    {
        if(speedIconHP>0)
        {
            speedIconHP-=2;
            if (SpeedIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
            {
                SpeedA.incrementSpeedA += 1;
                Destroy(SpeedIncrease.gameObject);
                Instantiate(psRed, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Movement.instance.Increase_P1_Speed();
            }
            if (SpeedIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
            {
                SpeedB.incrementSpeedB += 1;
                Destroy(SpeedIncrease.gameObject);
                Instantiate(psBlue, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Movement2.instance.Increase_P2_Speed();
            }
        }
    }
}
