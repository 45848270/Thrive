using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_and_Deactivate : MonoBehaviour
{
    public static Activate_and_Deactivate instance;
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public Player1SecondGun script1;
    public Player2SecondGun script2;
    public Cannon1 script3;
    public Cannon2 script4;


    private bool script1Activated = false; 
    private bool script2Activated = false;
    private bool script3Activated = false;
    private bool script4Activated = false;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Object1.SetActive(true);
        script1.enabled = false;

        Object2.SetActive(true);
        script2.enabled = false;

        Object3.SetActive(true);
        script3.enabled = false;

        Object4.SetActive(true);
        script4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (script1Activated)
        {
            Object1.SetActive(true);
            script1.enabled = true;
        }
        if (script2Activated)
        {
            Object2.SetActive(true);
            script2.enabled = true;
        }
        if (script3Activated)
        {
            Object3.SetActive(true);
            script3.enabled = true;
        }
        if (script4Activated)
        {
            Object4.SetActive(true);
            script4.enabled = true;
        }
    }

    public bool Activate_Player1_Second_Gun()
    {
        script1Activated = true;
        return script1Activated;
    }
    public bool Activate_Player2_Second_Gun()
    {
        script2Activated = true;
        return script2Activated;
    }
    public bool Activate_Player1_Cannon()
    {
        script3Activated = true;
        return script3Activated;
    }
    public bool Activate_Player2_Cannon()
    {
        script4Activated = true;
        return script4Activated;
    }
}
