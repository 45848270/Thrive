using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class buffNumUI : MonoBehaviour
{
    public GameObject DamageANum;
    public GameObject ReloadANum;
    public GameObject SpeedANum;
    public GameObject DamageBNum;
    public GameObject ReloadBNum;
    public GameObject SpeedBNum;

    public int damageANum;
    public int reloadANum;
    public int speedANum;
    public int damageBNum;
    public int reloadBNum;
    public int speedBNum;
    
    void Start()
    {
        damageANum=0;
        reloadANum=0;
        speedANum=0;
        damageBNum=0;
        reloadBNum=0;
        speedBNum=0;
        SetIniBuff();
    }

    // Update is called once per frame
    void Update()
    {
        SetBuffNum();
    }

    
    private void SetIniBuff()
    {
        if (DamageANum != null)
        {
            DamageANum.gameObject.SetActive(false);
        }
        if (ReloadANum != null)
        {
            ReloadANum.gameObject.SetActive(false);
        }
        if (SpeedANum != null)
        {
            SpeedANum.gameObject.SetActive(false);
        }
        if (DamageBNum != null)
        {
            DamageBNum.gameObject.SetActive(false);
        }
        if (ReloadBNum != null)
        {
            ReloadBNum.gameObject.SetActive(false);
        }
        if (SpeedBNum != null)
        {
            SpeedBNum.gameObject.SetActive(false);
        }
    }

    public void SetBuffNum()
    {
        DamageANum.GetComponent<TMPro.TextMeshProUGUI>().text ="*"+damageANum;
        ReloadANum.GetComponent<TMPro.TextMeshProUGUI>().text ="*"+reloadANum;
        SpeedANum.GetComponent<TMPro.TextMeshProUGUI>().text ="*"+speedANum;
        DamageBNum.GetComponent<TMPro.TextMeshProUGUI>().text ="*"+damageBNum;
        ReloadBNum.GetComponent<TMPro.TextMeshProUGUI>().text ="*"+reloadBNum;
        SpeedBNum.GetComponent<TMPro.TextMeshProUGUI>().text ="*"+speedBNum;
    }

    public void AddDamageANum()
    {
        DamageANum.gameObject.SetActive(true);
        damageANum+=1;
    }
    public void AddSpeedANum()
    {
        SpeedANum.gameObject.SetActive(true);
        speedANum+=1;
    }
    public void AddReloadANum()
    {
        ReloadANum.gameObject.SetActive(true);
        reloadANum+=1;
    }
    public void AddDamageBNum()
    {
        DamageBNum.gameObject.SetActive(true);
        damageBNum+=1;
    }
    public void AddSpeedBNum()
    {
        SpeedBNum.gameObject.SetActive(true);
        speedBNum+=1;
    }
    public void AddReloadBNum()
    {
        ReloadBNum.gameObject.SetActive(true);
        reloadBNum+=1;
    }
}
