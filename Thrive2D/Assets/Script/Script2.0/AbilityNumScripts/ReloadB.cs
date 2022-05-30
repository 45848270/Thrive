using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReloadB : MonoBehaviour
{
    public static int incrementReloadB = 0;
    public TextMeshProUGUI ReloadNumB;
    // Start is called before the fist frame update
    void Start()
    {
        ReloadNumB = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ReloadNumB.text = "X " + incrementReloadB.ToString();
    }
}
