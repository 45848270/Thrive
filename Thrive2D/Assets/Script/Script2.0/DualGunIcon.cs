using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualGunIcon : Item
{

    void OnTriggerEnter2D(Collider2D DualGun)
    {

        if (DualGun.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(DualGun.gameObject);
            Destroy(gameObject);
            Activate_and_Deactivate.instance.Activate_Player1_Second_Gun();
            Player1SecondGun.instance.dualGunOn = true;
        }
        if (DualGun.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(DualGun.gameObject);
            Destroy(gameObject);
            Activate_and_Deactivate.instance.Activate_Player2_Second_Gun();
            Player2SecondGun.instance.dualGunOn = true;

        }
    }



}
