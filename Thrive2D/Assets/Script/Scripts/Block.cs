using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Bricks
/// </summary>
public class Block : MonoBehaviour
{
    public GameObject followObj;
    public bool crash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Be hit
    /// </summary>
    public void OnHit()
    {
        Instantiate(followObj, transform.position, Quaternion.identity);
        if (crash)
        {
            GetComponentInChildren <Animator>().SetTrigger("Crash");
        }else
        {

            Destroy(gameObject);
        }
    }
    public void AniEnd()
    {
        Destroy(gameObject);
    }
}
