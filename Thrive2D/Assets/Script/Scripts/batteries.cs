using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batteries : MonoBehaviour
{
    public bool FireEnable;
    public float timerSpace;
    public float timer = 0;
    public GameObject bullet;
    public Transform firepos;
    public Transform icons;
    // Start is called before the first frame update
    void Start()
    {
        allPlayers = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManger.instance.gameEnd) return;
        if (FireEnable)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                timer = timerSpace;
                icons.right = allPlayers[0].position - transform.position;
                Instantiate(bullet, firepos.position, firepos.rotation);
            }
        }
    }
    List<Transform> allPlayers;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Player"))
        {
            if (!FireEnable)
            {
                FireEnable = true;
                timer = timerSpace;
            }

            allPlayers.Add(collision.transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Contains("Player"))
        {
            allPlayers.Remove(collision.transform);
            if (allPlayers.Count == 0)
            {
                FireEnable = false;
                timer = 0;
            }
        }

    }
}
