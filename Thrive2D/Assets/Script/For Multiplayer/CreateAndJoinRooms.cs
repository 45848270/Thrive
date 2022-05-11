using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public GameObject canvas;
    public GameObject playerPrefab;
    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
        canvas.SetActive(false);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(playerPrefab.name,new Vector2(5,0), Quaternion.identity);

    }

}
