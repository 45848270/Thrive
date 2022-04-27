using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIcon : Item
{

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D DamageIncrease)
    {

        if (DamageIncrease.gameObject.tag.Equals("player1Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(DamageIncrease.gameObject);
            Destroy(gameObject);
            Health.instance.IncreasePlayer1DamagePerCOntact();
        }
        if (DamageIncrease.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(DamageIncrease.gameObject);
            Destroy(gameObject);
            Health.instance.IncreasePlayer2DamagePerCOntact();
        }
    }
}
