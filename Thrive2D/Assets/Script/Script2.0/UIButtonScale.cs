using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIButtonScale : MonoBehaviour
{

    private List<Transform> buttonsPool;
    private Vector3 sizeChangeTo;
    private Vector3 initalSize;
    private int curButtonInx;

    void Start()
    {
        sizeChangeTo = new Vector3(1.3f, 1.3f, 1.3f);
        initalSize = new Vector3(1.0f, 1.0f, 1.0f);
        curButtonInx = 0;

        buttonsPool = new List<Transform>();
        ListButtons();

    }

    // Update is called once per frame
    void Update()
    {
        ScaleButtons();
    }

    public void ListButtons()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (this.gameObject.transform.GetChild(i).GetComponent<Button>() != null)
            {
                buttonsPool.Add(this.gameObject.transform.GetChild(i));
            }
        }
    }

    public void ScaleButtons()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))//move down to the next option
        {
            if (curButtonInx < buttonsPool.Count - 1)
            {
                curButtonInx++;
            }
            else
            {
                curButtonInx = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))//move up to the last option
        {
            if (curButtonInx > 0)
            {
                curButtonInx--;
            }
            else
            {
                curButtonInx = buttonsPool.Count - 1;
            }
        }

        for (int i = 0; i < buttonsPool.Count; i++)
        {
            RectTransform rectOfButton = buttonsPool[i].GetComponent<RectTransform>();//option changed as the one that the mouse's position
            bool MouseOnButton = RectTransformUtility.RectangleContainsScreenPoint(rectOfButton, Input.mousePosition); ;
            if (MouseOnButton)
            {
                curButtonInx = i;
            }
        }

        for (int i = 0; i < buttonsPool.Count; i++)
        {
            if (i == curButtonInx)
            {
                buttonsPool[i].transform.localScale = sizeChangeTo;
                //this is the key clicks the buttons selected (currently its Enter Key)
                if (Input.GetKeyDown(KeyCode.Return)) //unity uses KeyCode.Return to press enter key,
                {
                    buttonsPool[i].GetComponent<Button>().onClick.Invoke();
                }
            }
            else
            {
                buttonsPool[i].transform.localScale = initalSize;
            }
        }



    }
}
