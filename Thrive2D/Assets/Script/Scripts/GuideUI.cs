using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideUI : MonoBehaviour
{
    public List<Sprite> allGuides;
    public Image img;
    public Button lastBtn, nextBtn;
    public int currnetindex;
    public GameObject sureBtn;
    // Start is called before the first frame update
    void Start()
    {
        ShowGuide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGuide()
    {
        img.sprite = allGuides[currnetindex];
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dir"></param>
    public void ChangeIndex(int dir)
    {
        currnetindex += dir;
        ShowGuide();
        if(currnetindex == 0 )
        {
            lastBtn.interactable = false;
        }
        else if(currnetindex== allGuides .Count - 1)
        {
            nextBtn.interactable = false;
            sureBtn.SetActive(true);
        }
        else
        {
            sureBtn.SetActive(false );
            lastBtn.interactable = true;
            nextBtn.interactable = true;
        }
    }
}
