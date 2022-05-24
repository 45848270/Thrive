using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReloadA : MonoBehaviour
{
    public static int incrementReloadA = 0;
    public TextMeshProUGUI ReloadNumA;
    // Start is called before the fist frame update
    void Start()
    {
        ReloadNumA = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ReloadNumA.text = "X " + incrementReloadA.ToString();
    }
}
