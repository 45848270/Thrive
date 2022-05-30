using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryHealth : MonoBehaviour
{
    public int maxHp;
    private int currentHp;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        slider.maxValue = maxHp;
        slider.value = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.tag .Contains("Bullet"))
        {
            currentHp -= 1;
            slider .value = currentHp;  
            if(currentHp <= 0)
            {
                Destroy(transform .parent . gameObject);
            }
            Destroy (collision .gameObject);    
        }
    }
}
