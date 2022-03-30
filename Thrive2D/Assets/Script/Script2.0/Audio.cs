// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Audio : MonoBehaviour
// {
//      //public AudioSource HurtSound;
//    // public AudioSource HurtSound1;
//    // public AudioClip sound;
   
//    public static AudioClip firstSound, secondSound;
//     static AudioSource audioSrc;

//     // Start is called before the first frame update
//     void Start()
//     {
//          //HurtSound = GetComponent<AudioSource> ();
//        // HurtSound1 = GetComponent<AudioSource> ();
//         //sound = GetComponent<AudioClip> ();
//         //sound.Play();
//        //HurtSound.Play();
//         firstSound = Resources.Load<AudioClip> ("first");
//         secondSound = Resources.Load<AudioClip> ("second");
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }


//     public static void PlaySound (string clip)
//     {
//         switch (clip) {
//             case "first":
//             audioSrc.PlayOneShot (firstSound);
//             break;        
//            case "second":
//             audioSrc.PlayOneShot (secondSound);
//             break;
//         }
//     }
// }
