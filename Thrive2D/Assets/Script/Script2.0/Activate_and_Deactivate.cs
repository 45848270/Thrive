using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_and_Deactivate : MonoBehaviour
{
    public static Activate_and_Deactivate instance;
    public GameObject Object1;
    public GameObject Object2;
    public Player1SecondGun script1;
    public Player2SecondGun script2;

    private bool script1Activated=false;
    private bool script2Activated=false;

    void Awake()
    {
        instance=this;
    }

    // Start is called before the first frame update
    void Start()
    {
       Object1.SetActive(true);
       script1.enabled=false; 

       Object2.SetActive(true);
       script2.enabled=false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(script1Activated)
        {
        Object1.SetActive(true);
        script1.enabled=true; 
        }
        if(script2Activated)
        {
        Object2.SetActive(true);
        script2.enabled=true; 
        }
    }

    public bool Activate_Player1_Second_Gun()
    {
        script1Activated=true;
        return script1Activated;
    }
    public bool Activate_Player2_Second_Gun()
    {
        script2Activated=true;
        return script2Activated;
    }
}
