using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Gun : MonoBehaviour
{
    public Transform initialPos;
    public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown(InputAxes.P2_bDirX) ||Input.GetButtonDown(InputAxes.P2_bDirY)) 
        {
            shoot();
        }
    }

    void shoot()
    {
        //shooting method
        Instantiate(bulletPrefab, initialPos.position, initialPos.rotation);
    }
}
