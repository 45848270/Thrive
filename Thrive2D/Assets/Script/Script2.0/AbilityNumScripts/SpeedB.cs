using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedB : MonoBehaviour
{
    public static int incrementSpeedB = 0;
    public TextMeshProUGUI SpeedNumB;
    // Start is called before the first frame update
    void Start()
    {
        SpeedNumB = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        SpeedNumB.text = "X " + incrementSpeedB.ToString();
    }
}
