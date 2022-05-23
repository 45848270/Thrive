using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Bricks
/// </summary>
public class Block : MonoBehaviour
{
    public bool crash;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Bullet") || collision.tag.Contains("Cannon"))
        {
            Destroy(collision.gameObject);
            OnHit();

        }
    }
    /// <summary>
    /// Be hit 
    /// </summary>
    public void OnHit()
    {
        FindObjectOfType<RandomItem>().RandomClone(transform .position );
        if (crash)
        {
            GetComponentInChildren<Animator>().SetTrigger("Crash");
        }
        else
        {

            Destroy(gameObject);
        }
    }
    public void AniEnd()
    {
        Destroy(gameObject);
    }
}
