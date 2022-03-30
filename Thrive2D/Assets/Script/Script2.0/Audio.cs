using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
     public AudioSource HurtSound;
    public AudioSource HurtSound1;
    //public AudioClip sound;
       


    // Start is called before the first frame update
    void Start()
    {
        HurtSound = GetComponent<AudioSource> ();
        HurtSound1 = GetComponent<AudioSource> ();
        //sound = GetComponent<AudioClip> ();
        //sound.Play();
       // HurtSound.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
