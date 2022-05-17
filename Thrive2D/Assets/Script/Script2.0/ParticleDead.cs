using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDead : MonoBehaviour
{
    //private GameObject player1;
    //private GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
     //   player1=GameObject.FindWithTag("Player1");
     //   player2=GameObject.FindWithTag("Player2");
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag.Equals("Player1") || collide.gameObject.tag.Equals("Player2"))
        {
           Destroy(gameObject); 
        }
    }
}
