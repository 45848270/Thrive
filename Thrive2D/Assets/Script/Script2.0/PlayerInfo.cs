using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour{

public Gameobject Panel;

public void OpenPanel()
{
    if(Panel != null)
    {
        Panel.SetActive(true);
    }
}


}