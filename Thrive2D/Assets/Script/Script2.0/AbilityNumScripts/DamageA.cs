using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DamageA : MonoBehaviour
{
    public static int incrementDamA = 0; 
    public TextMeshProUGUI damageNumA;
    // Start is called before the first frame update
    void Start()
    {
        damageNumA = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        damageNumA.text = "X " + incrementDamA.ToString();
    }
}
