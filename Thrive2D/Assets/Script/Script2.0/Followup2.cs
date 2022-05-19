using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followup2 : MonoBehaviour
{
   public GameObject player;
    public float moveSpeed=20;
    public ParticleSystem ps;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody2D>();  
        if(player == null)
        {
            player=GameObject.FindWithTag("Player2");
        }  
        ps.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction =player.transform.position-transform.position;
        float angle =Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;

        rb.rotation=angle;
        direction.Normalize();
        movement=direction;

        Destroy(gameObject,2f);
    }
    void FixedUpdate() 
    {
    moveCharacter(movement);
    //ps.Play();   
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position +(direction*moveSpeed*Time.deltaTime));
    }

     void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag.Equals("Player2"))
        {
            ps.Stop();
           Destroy(this.gameObject); 
        }
    }
}
