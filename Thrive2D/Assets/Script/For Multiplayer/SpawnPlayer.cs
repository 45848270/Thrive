using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
   public GameObject playerPrefab;
   
   private void Start()
   {
       PhotonNetwork.Instantiate(playerPrefab.name,new Vector2(5,0), Quaternion.identity);
   }

}
