using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public float DestroyTime=30;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
