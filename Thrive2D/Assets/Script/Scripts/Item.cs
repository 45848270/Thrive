using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ItemType
{
    AddHp,
    AddDamage
}

public class Item : MonoBehaviour
{
    public ItemType type;
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
        if(collision.tag == "Player")
        {
            switch (type)
            {
                case ItemType.AddHp:
                    collision.GetComponent<PlayerBase>().AddHp(10);
                    break;
                case ItemType.AddDamage:
                    collision.GetComponent<PlayerBase>().AddDamage (5);
                    break;
                default:
                    break;
            }
            Destroy(gameObject);
        }
    }
}
