using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour
{
    public float revTime;

    private void Start()
    {
        if (revTime > 0)
            Destroy(gameObject, revTime);
    }

}
