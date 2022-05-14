using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class RoomItem : MonoBehaviour
{
   public TMP_Text roomName;
   CreateAndJoinRooms manger;

   private void Start()
   {
       manger=FindObjectOfType<CreateAndJoinRooms>();
   }

   public void SetRoomName(string _roomName)
   {
       roomName.text=_roomName;
   }

   public void OnClickItem()
   {
       manger.JoinRoom(roomName.text);
   }

}
