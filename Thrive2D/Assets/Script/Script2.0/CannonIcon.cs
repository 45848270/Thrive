using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonIcon : Item
{

    void OnTriggerEnter2D(Collider2D Cannon)
    {

        if (Cannon.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(Cannon.gameObject);
            Destroy(gameObject);
            Activate_and_Deactivate.instance.Activate_Player1_Cannon();
        }
        if (Cannon.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(Cannon.gameObject);
            Destroy(gameObject);
            Activate_and_Deactivate.instance.Activate_Player2_Cannon();


        }
    }
}
