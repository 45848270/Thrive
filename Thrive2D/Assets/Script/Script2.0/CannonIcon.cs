using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonIcon : Item
{   
    public GameObject psRed;
    public GameObject psBlue;

    private int cannonIconHp = 1;


    void OnTriggerEnter2D(Collider2D Cannon)
    {
        if(cannonIconHp>0)
        {
            cannonIconHp-=2;
            if (Cannon.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
            {
                Destroy(Cannon.gameObject);
                Instantiate(psRed,transform.position,Quaternion.identity);
                Destroy(gameObject);
                Activate_and_Deactivate.instance.Activate_Player1_Cannon();
                Cannon1.instance.CannonShootOnce = true;
            }
            if (Cannon.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
            {
                Destroy(Cannon.gameObject);
                Instantiate(psBlue,transform.position,Quaternion.identity);
                Destroy(gameObject);
                Activate_and_Deactivate.instance.Activate_Player2_Cannon();
                Cannon2.instance.CannonShootOnce = true;

 
        }
        }
    }
}
 