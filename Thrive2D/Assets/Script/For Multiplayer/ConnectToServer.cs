using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ConnectToServer : MonoBehaviourPunCallbacks
{

    public TMP_InputField userInput;
    public TMP_Text buttonText;
    // Start is called before the first frame update


    public void OnClickConnect()
    {
        if (userInput.text.Length>=1)
        {
            PhotonNetwork.NickName=userInput.text;
            buttonText.text="Connecting...";
            PhotonNetwork.AutomaticallySyncScene=true;
            PhotonNetwork.ConnectUsingSettings();    
        }
        
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Lobby");
    }


}
