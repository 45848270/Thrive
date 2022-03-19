using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Gun : MonoBehaviour
{
    public Transform initialPos;
    public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown(InputAxes.P1_bDirX) ||Input.GetButtonDown(InputAxes.P1_bDirY)) 
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
