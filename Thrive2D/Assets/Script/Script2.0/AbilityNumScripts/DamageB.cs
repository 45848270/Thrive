using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DamageB : MonoBehaviour
{
    public static int incrementDamB = 1; 
    public TextMeshProUGUI damageNumB;
    // Start is called before the first frame update
    void Start()
    {
        damageNumB = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        damageNumB.text = "X " + incrementDamB.ToString();
    }
}
