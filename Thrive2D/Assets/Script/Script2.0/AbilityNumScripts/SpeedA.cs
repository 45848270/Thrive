using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedA : MonoBehaviour
{
    public static int incrementSpeedA = 0; 
    public TextMeshProUGUI speedNumA;
    // Start is called before the first frame update
    void Start()
    {
        speedNumA = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        speedNumA.text = "X " + incrementSpeedA.ToString();
    }
}
