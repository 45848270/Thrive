using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKit : MonoBehaviour
{
    public GameObject healthkitprefab;
    public float healthkitLastFor=4f;
    public float spawnTime=10f;

    public float time1;

    // Start is called before the first frame update
    void Start()
    {
        time1=spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (time1<=0)
        {
            AppearHealthKit();
            time1=spawnTime+healthkitLastFor;
              
        }
        else
        {
            time1-=Time.deltaTime;
        }
    }

    public void AppearHealthKit()
    {
        Vector2 location=new Vector2(Random.Range(-6,6),Random.Range(-4,4));
        Instantiate(healthkitprefab,location, Quaternion.identity);
    }
}
