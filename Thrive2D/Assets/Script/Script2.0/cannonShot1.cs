using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonShot1 : MonoBehaviour
{
    public float speed = 10;



    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject, 3f);


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D damageGivenToP2)
    {
        if (damageGivenToP2.gameObject.tag.Equals("Player1"))
            return;
        Destroy(gameObject);

        if (damageGivenToP2.gameObject.tag.Equals("Player2"))                                            //condition if it comes in contact with enemy
        {
            Health.instance.Decrease_P2_Health_Cannon();

        }
        if (damageGivenToP2.gameObject.tag.Equals("player2Cannon"))                                            //condition if it comes in contact with enemy
        {
            Destroy(damageGivenToP2.gameObject);
        }
    }
}
