using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadIcon : Item
{

    public GameObject psRed;
    public GameObject psBlue;

    void OnTriggerEnter2D(Collider2D ReloadIncrease)
    {

        if (ReloadIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            ReloadA.incrementReloadA += 1;
            Destroy(ReloadIncrease.gameObject);
            Instantiate(psRed, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Player1FirstGun.instance.Decrease_P1_ReloadTime();
            Player1SecondGun.instance.Decrease_P1_ReloadTime();
        }
        if (ReloadIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            ReloadB.incrementReloadB += 1;
            Destroy(ReloadIncrease.gameObject);
            Instantiate(psBlue, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Player2FirstGun.instance.Decrease_P2_ReloadTime();
            Player2SecondGun.instance.Decrease_P2_ReloadTime();
        }
    }
}
