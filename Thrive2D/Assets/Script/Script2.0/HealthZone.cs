using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZone : MonoBehaviour
{
    public float zoneActivation_Time=1f;
    public bool player1ZoneTime=false;
    public bool player2ZoneTime=false;
    public float player1Time=2.0f;
    public float player2Time=2.0f;
     //public static AudioClip charging;

   public AudioSource HealthSound;
    

    // Start is called before the first frame update
    void Start()
    {
        HealthSound =  GetComponent<AudioSource> ();
         //charging = Resources.Load<AudioClip> ("charging");        
         
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player1ZoneTime)
        {
            player1Time-=Time.deltaTime;
            if(player1Time<=0)
            {
                Health.instance.Player1MaxHealth(2);
                player1Time=zoneActivation_Time;
               
            }
        }
        if(player2ZoneTime)
        {
            player2Time-=Time.deltaTime;
            if(player2Time<=0)
            {
                Health.instance.Player2MaxHealth(2);
                player2Time=zoneActivation_Time;
            }
        }
      
    }
    void OnTriggerStay2D(Collider2D healthzone)
    {
         if (healthzone.gameObject.tag.Equals("Player1"))                                            //condition if it comes in contact with enemy
        {
                player1ZoneTime=true;  
                 HealthSound.Play();


        }      
        if (healthzone.gameObject.tag.Equals("Player2"))                                            //condition if it comes in contact with enemy
        { 
                
                player2ZoneTime=true; 
                HealthSound.Play();  
                
                //Debug.Log("charging");

               
                                                                   
        }
    }

    void OnTriggerExit2D(Collider2D healthzone)
    {
         if (healthzone.gameObject.tag.Equals("Player1"))                                            //condition if it comes in contact with enemy
        {
                player1ZoneTime=false;                  
            //Debug.Log("Not charging");


        }
        if (healthzone.gameObject.tag.Equals("Player2"))                                            //condition if it comes in contact with enemy
        { 
                player2ZoneTime=false;      
             //Debug.Log("Not charging");
                                                                
        }
    }
}
