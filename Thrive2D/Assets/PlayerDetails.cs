using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetails : MonoBehaviour
{
    public int playerID;
    public Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos;
    }
}