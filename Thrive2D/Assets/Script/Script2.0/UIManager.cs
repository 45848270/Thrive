using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelPanel;
    public GameObject guideNPC;
    public GameObject dialoguePanel;
    public GameObject dialogueText;
    public GameObject pausePanel;

    public List<string> dialogueTextList;
    private int curDiaInx;


    //Scene orders:
    private int MainSceneOrder = 0;
    private int FirstlevelOrder = 1;
    private int SecondlevelOrder = 2;
    private int ThirdLevelOrder = 3;

    void Start()
    {
        dialogueTextList = new List<string>();
        InitUI();
        SetDialogueTextList();
    }

    void Update()
    {
        if (dialoguePanel != null)
        {
            TurnPages();
        }
    }

    public void InitUI()
    {
        //intialize UI elements
        if (menuPanel != null)
        {
            menuPanel.gameObject.SetActive(true);
        }
        if (levelPanel != null)
        {
            levelPanel.gameObject.SetActive(false);
        }
        if (guideNPC != null)
        {
            guideNPC.gameObject.SetActive(false);
        }
        if (dialoguePanel != null)
        {
            dialoguePanel.gameObject.SetActive(false);
        }
        if (pausePanel != null)
        {
            pausePanel.gameObject.SetActive(false);
        }
    }

    public void SetDialogueTextList()
    {
        //add text in the dialogue, set the first sentense as the first page in the scene
        if (dialoguePanel != null)
        {
            dialogueTextList.Add("Some background story we may or may not add in future");
            dialogueTextList.Add("Player A uses w a s d keys to move, uses i j k l keys to shoot");
            dialogueTextList.Add("Player B uses arrow keys to move, uses num 8 5 4 6 keys to shoot");
            string tempDia = dialogueTextList[0];
            dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text = tempDia;
            curDiaInx = 0;
        }
    }



    public void InitDia()
    {
        //after click play button, init npc and dialogue panel
        menuPanel.gameObject.SetActive(false);
        guideNPC.gameObject.SetActive(true);
        dialoguePanel.gameObject.SetActive(true);
    }

    public void TurnPages()
    {
        //if click the dialogue box, or press space button, 
        //turn pages in dialogue box.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (curDiaInx < dialogueTextList.Count - 1)
            {
                curDiaInx++;
                dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text = dialogueTextList[curDiaInx];
            }
            else
            {
                ChooseLevel();
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            RectTransform rect = dialoguePanel.GetComponent<RectTransform>();
            bool mouseOnDia = RectTransformUtility.RectangleContainsScreenPoint(rect, Input.mousePosition);
            if (curDiaInx < dialogueTextList.Count - 1)
            {
                if (mouseOnDia)
                {
                    curDiaInx++;
                    dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text = dialogueTextList[curDiaInx];
                }
            }
            else
            {
                if (mouseOnDia)
                {
                    ChooseLevel();
                }
            }
        }
    }


    public void ChooseLevel()
    {
        //after Npc talks, active level panel
        dialoguePanel.gameObject.SetActive(false);
        guideNPC.gameObject.SetActive(false);
        levelPanel.gameObject.SetActive(true);
    }

    public void LoadFirstLevel()
    {
        //load scene based on oreder of building settings
        SceneManager.LoadScene(FirstlevelOrder);
    }

    public void LoadSecondLevel()
    {
        //load scene based on oreder of building settings
        SceneManager.LoadScene(SecondlevelOrder);
    }

    public void LoadThirdLevel()
    {
        //load scene based on oreder of building settings
        SceneManager.LoadScene(ThirdLevelOrder);
    }

    public void CallPause()
    {
        //active pause panel after clicking pause button
        pausePanel.gameObject.SetActive(true);
    }

    public void CallResume()
    {
        //disactive pause panel after clicking resume button on pause panel
        pausePanel.gameObject.SetActive(false);
    }

    public void CallBackToMain()
    {
        //back to main scene after clicking Back to main button on pause panel
        pausePanel.gameObject.SetActive(false);
        SceneManager.LoadScene(MainSceneOrder);
    }

    public void ExitGame()
    {
        //quit editting mode in unity, also quit game
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
