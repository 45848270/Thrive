using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public float moveSpeed = 10;
    public float timeDestroy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector2.right * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CheckPoint") return;
        Destroy(gameObject);
        Debug .Log (collision .tag );
        if(collision .tag == "Player")
        {
            collision.GetComponent<PlayerBase>().OnHurt(damage);
        }else if(collision.tag == "Block")
        {
            collision.GetComponent<Block>().OnHit();
        }
    }
}
