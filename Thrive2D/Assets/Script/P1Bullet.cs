using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Bullet : MonoBehaviour
{
    public float bulletSpeed = 40f;
    //public Rigidbody2D bullet;

    private float yDir;
    private float xDir;
    private bool isFireUp;
    private bool isFireDown;
    private bool isFireLeft;
    private bool isFireRight;
    private Vector2 vec;

    
    // Start is called before the first frame update
    void Start()
    {
        yDir = Input.GetAxis(InputAxes.P1_bDirY);
        Debug.Log(yDir);
        xDir = Input.GetAxis(InputAxes.P1_bDirX);
        /*
        if (Input.GetButtonDown(InputAxes.P1_bDirX))
        {
            bullet.velocity = transform.right * bulletSpeed * xDir;
        }
        if (Input.GetButtonDown(InputAxes.P1_bDirY))
        {
            bullet.velocity = transform.up * bulletSpeed * yDir;
        }
        if ((Input.GetButtonDown(InputAxes.P1_bDirY)) && (Input.GetButtonDown(InputAxes.P1_bDirX)))
        {
            vec = new Vector2(xDir, yDir);
            bullet.velocity = vec * bulletSpeed;
        }
        Destroy(gameObject, 3f); */
         isFireUp = false;
        isFireDown = false;
        SetFireDirection();
        Destroy(gameObject, 4f);
    }
    // Update is called once per frame
     void Update()
    {
        BulletMoves();

    }

    void SetFireDirection()
    {
        if (yDir>0)
        {
            isFireUp = true;
        }

        if (yDir<0)
        {
            isFireDown = true;
        }

        if (xDir<0)
        {
            isFireLeft = true;
        }

        if (xDir>0)
        {
            isFireRight = true;
        }
    }

     void BulletMoves()
    {
        if (isFireUp)
        {
            transform.Translate(bulletSpeed * Time.deltaTime * Vector3.up);
        }

        if (isFireDown)
        {
            transform.Translate(bulletSpeed * Time.deltaTime * Vector3.down);
        }

        if (isFireLeft)
        {
            transform.Translate(bulletSpeed * Time.deltaTime * Vector3.left);
        }

        if (isFireRight)
        {
            transform.Translate(bulletSpeed * Time.deltaTime * Vector3.right);
        }
    }
    void OnTriggerEnter2D(Collider2D damageGivenToP2)
    {
        Debug.Log(damageGivenToP2.name);

         if (damageGivenToP2.gameObject.tag.Equals("Player2"))                                            //condition if it comes in contact with enemy
        {
            Destroy(damageGivenToP2.gameObject);                                                       //Destroys the enemy
            Destroy(gameObject);                                                                    //Bullet Get Self Destroyed
        }
        if (damageGivenToP2.gameObject.tag.Equals("player2Bullet"))                                            //condition if it comes in contact with enemy
        {
            Destroy(damageGivenToP2.gameObject);                                                       //Destroys the enemy
            Destroy(gameObject);                                                                    //Bullet Get Self Destroyed
        }
    }
}
