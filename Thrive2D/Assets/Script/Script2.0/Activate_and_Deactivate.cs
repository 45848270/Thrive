using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_and_Deactivate : MonoBehaviour
{
    public GameObject Object;
    public Player1SecondGun script;

    // Start is called before the first frame update
    void Start()
    {
       Object.SetActive(true);
       script.enabled=false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
        Object.SetActive(true);
       script.enabled=true; 
        }
    }
}
