using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;


public class UIManager : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelPanel;
    public GameObject dialoguePanel;
    public GameObject dialogueText;
    public GameObject pausePanel;
    public GameObject optionPanel;
    public GameObject audioPanel;
    public GameObject controllerPanel;
    public GameObject keyboardPanel;

    public GameObject GameOverPanel;

    public GameObject levelOneDiaguePanel;
    public GameObject levelOneDiagueText;
    public GameObject levelTwoDiaguePanel;
    public GameObject levelTwoDiagueText;
    public GameObject levelThreeDiaguePanel;
    public GameObject levelThreeDiagueText;
    public GameObject pauseButton;

    public List<string> dialogueTextList;
    public List<string> levelOneDiagueTextList;
    public List<string> levelTwoDiagueTextList;
    public List<string> levelThreeDiagueTextList;
    private int curDiaInx;
    private int curLevOneDiaInx;
    private int curLevTwoDiaInx;
    private int curLevThreeDiaInx;
    private bool IsMainDiaFinished;

    // for UI buttons with gamepad
    public GameObject pauseFirstButton, optionFirstButton, optionClosedButton, audioFirstButton, audioClosedButton, controllerFirstButton, controllerClosedButton, keyboardFirstButton, keyboardClosedButton, gameoverFirstButton, gameoverClosedButton, chooseLevelFirstButton;
    public GameObject menuPlayButton, menuAfterPlayButton, level1FirstDialogueButton;

    //Scene orders:
    private int MainSceneOrder = 0;
    private int FirstlevelOrder = 1;
    private int SecondlevelOrder = 2;
    private int ThirdLevelOrder = 3;

    private bool SelectedLevelOne;
    private bool SelectedLevelTwo;
    private bool SelectedLevelThree;

    void Start()
    {
        IsMainDiaFinished = false;
        dialogueTextList = new List<string>();
        InitUI();
        SetDialogueTextList();
        SelectedLevelOne = false;
        SelectedLevelTwo = false;
        SelectedLevelThree = false;

        optionPanel.gameObject.SetActive(false);
        audioPanel.gameObject.SetActive(false);
        controllerPanel.gameObject.SetActive(false);
        keyboardPanel.gameObject.SetActive(false);


        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(menuPlayButton);

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
        if (dialoguePanel != null)
        {
            dialoguePanel.gameObject.SetActive(false);
        }
        if (levelOneDiaguePanel != null)
        {
            levelOneDiaguePanel.gameObject.SetActive(false);
        }
        if (levelTwoDiaguePanel != null)
        {
            levelTwoDiaguePanel.gameObject.SetActive(false);
        }
        if (levelThreeDiaguePanel != null)
        {
            levelThreeDiaguePanel.gameObject.SetActive(false);
        }

        if (pausePanel != null)
        {
            pausePanel.gameObject.SetActive(false);
        }

        if (GameOverPanel != null)
        {
            GameOverPanel.gameObject.SetActive(false);
        }
    }

    public void SetDialogueTextList()
    {
        //add text in the dialogue, set the first sentense as the first page in the scene
        if (dialoguePanel != null)
        {
            dialogueTextList.Add("In the history of human development, there has always been struggles for resources. After the explosion of space transportation technology, ");
            dialogueTextList.Add("some people realized that the benefits of robbing the transport space fleet were large enough to make them willing to risk their lives.");
            dialogueTextList.Add("Then, the arms race between space outlaws and interstellar police continued for centuries.");
            dialogueTextList.Add("As a space outlaw who provides shelter for the exiles, PlayerA, now you are about to get enough resources to provide a new beginning for hundreds of people, ");
            dialogueTextList.Add("they will no longer need to risk nuclear radiation to have a warm place to live--");
            dialogueTextList.Add("You only need to rob one last time");
           // dialogueTextList.Add("Use the w a s d keys to pilot the ship, Space Key to shoot bullets and Shift to shoot Cannon at any target that gets in your way. Check your abilities by using Tab key.");
            dialogueTextList.Add("As an interstellar police who has sworn to protect the new order, PlayerB, in the past six months, all people in a small town have been displaced because of the robbery.");
            dialogueTextList.Add("Now, you finally found the clue of the gang leader --");
            dialogueTextList.Add("It is time to end this chaos.");
          //  dialogueTextList.Add("Use the arrow keys to pilot the ship, num pad 5 to shoot bullets and num pad 2 to shoot Cannon, making your target pays for his viciousness. View your abilities by using num pad Enter key.");
            string tempDia = dialogueTextList[0];
            dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text = tempDia;
            curDiaInx = 0;
        }

        if (levelOneDiaguePanel != null)
        {
            levelOneDiagueTextList.Add("The outlaw received a new robbery target-- a fleet is about to pass through this abandoned base,");
            levelOneDiagueTextList.Add(" but when he gets here, he realizes that as an abandoned base, the traces of human activities here are too new. . .");
            string tempLevelOneDia = levelOneDiagueTextList[0];
            levelOneDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = tempLevelOneDia;
            curLevOneDiaInx = 0;
        }

        if (levelTwoDiaguePanel != null)
        {
            levelTwoDiagueTextList.Add("After a week of hidding, the outlaw realizes that the time has come, and he steers the ship toward his robbery target.");
            levelTwoDiagueTextList.Add("At the same time, he is also exposed by the youngest interstellar policeman. . .");
            string tempLevelTwoDia = levelTwoDiagueTextList[0];
            levelTwoDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = tempLevelTwoDia;
            curLevTwoDiaInx = 0;
        }

        if (levelThreeDiaguePanel != null)
        {
            levelThreeDiagueTextList.Add("This last time rob was much easier than the outlaw expected, but the joy of the imminent realization of the dream did not go to his head.");
            levelThreeDiagueTextList.Add("He found the spaceship not far from him, is fully armed.");
            string tempLevelThreeDia = levelThreeDiagueTextList[0];
            levelThreeDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = tempLevelThreeDia;
            curLevThreeDiaInx = 0;
        }
    }



    public void InitDia()
    {
        //after click play button, init npc and dialogue panel
        if (menuPanel != null)
        {
            menuPanel.gameObject.SetActive(false);
        }
        dialoguePanel.gameObject.SetActive(true);

         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(menuAfterPlayButton);
    }

    public void Option()
    {        
        optionPanel.SetActive(true);
        pausePanel.SetActive(false);

         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(optionFirstButton);
    }

    public void CloseOption()
    {
        //disactive option panel after clicking back button on option panel
        if (optionPanel != null)
        {
            optionPanel.gameObject.SetActive(false);
        }
                pausePanel.SetActive(true);

         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(optionClosedButton);
        
    }   

    public void ControllerPanelOption()
    {
        
        optionPanel.SetActive(false);
        controllerPanel.SetActive(true);


         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(controllerFirstButton);
        
    }

     public void ControllerPanelOptionBack()
    {
        
        optionPanel.SetActive(true);
        controllerPanel.SetActive(false);


         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(controllerClosedButton);
        
    }

     public void KeyboardPanelOption()
    {
        
        optionPanel.SetActive(false);
        keyboardPanel.SetActive(true);


         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(keyboardFirstButton);
        
    }

     public void KeyboardPanelOptionBack()
    {
        
        optionPanel.SetActive(true);
        keyboardPanel.SetActive(false);


         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(keyboardClosedButton);
        
    }

  public void AudioOption()
    {
        
        audioPanel.SetActive(true);
        optionPanel.SetActive(false);
        pausePanel.SetActive(false);


         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(audioFirstButton);
        
    }

    public void AudioBackToOption()
    {
        
        audioPanel.SetActive(false);
        optionPanel.SetActive(true);
         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(audioClosedButton);
        
    }
    

    public void TurnPages()
    {
        //if click the dialogue box, or press space button, 
        //turn pages in dialogue box.
        if (!IsMainDiaFinished)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (curDiaInx < dialogueTextList.Count - 1)
                {
                    curDiaInx++;
                    dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text = dialogueTextList[curDiaInx];
                }
                else
                {
                    IsMainDiaFinished = true;
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
                        IsMainDiaFinished = true;
                        ChooseLevel();
                    }
                }
            }
        }
        else //Main dia is finished
        {
            if (SelectedLevelOne)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (curLevOneDiaInx < levelOneDiagueTextList.Count - 1)
                    {
                        curLevOneDiaInx++;
                        levelOneDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = levelOneDiagueTextList[curLevOneDiaInx];
                    }
                    else
                    {
                        LoadFirstLevel();
                    }
                }
                if (Input.GetMouseButtonDown(0))
                {
                    RectTransform rectOne = levelOneDiaguePanel.GetComponent<RectTransform>();
                    bool mouseOnDiaOne = RectTransformUtility.RectangleContainsScreenPoint(rectOne, Input.mousePosition);
                    if (curLevOneDiaInx < levelOneDiagueTextList.Count - 1)
                    {
                        if (mouseOnDiaOne)
                        {
                            curLevOneDiaInx++;
                            levelOneDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = levelOneDiagueTextList[curLevOneDiaInx];
                        }
                    }
                    else
                    {
                        if (mouseOnDiaOne)
                        {
                            LoadFirstLevel();
                        }
                    }
                }
            }

            if (SelectedLevelTwo)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (curLevTwoDiaInx < levelTwoDiagueTextList.Count - 1)
                    {
                        curLevTwoDiaInx++;
                        levelTwoDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = levelTwoDiagueTextList[curLevTwoDiaInx];
                    }
                    else
                    {
                        LoadSecondLevel();
                    }
                }
                if (Input.GetMouseButtonDown(0))
                {
                    RectTransform rectTwo = levelTwoDiaguePanel.GetComponent<RectTransform>();
                    bool mouseOnDiaTwo = RectTransformUtility.RectangleContainsScreenPoint(rectTwo, Input.mousePosition);
                    if (curLevTwoDiaInx < levelTwoDiagueTextList.Count - 1)
                    {
                        if (mouseOnDiaTwo)
                        {
                            curLevTwoDiaInx++;
                            levelTwoDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = levelTwoDiagueTextList[curLevTwoDiaInx];
                        }
                    }
                    else
                    {
                        if (mouseOnDiaTwo)
                        {
                            LoadSecondLevel();
                        }
                    }
                }
            }

            if (SelectedLevelThree)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (curLevThreeDiaInx < levelThreeDiagueTextList.Count - 1)
                    {
                        curLevThreeDiaInx++;
                        levelThreeDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = levelThreeDiagueTextList[curLevThreeDiaInx];
                    }
                    else
                    {
                        LoadThirdLevel();
                    }
                }
                if (Input.GetMouseButtonDown(0))
                {
                    RectTransform rectThree = levelThreeDiaguePanel.GetComponent<RectTransform>();
                    bool mouseOnDiaThree = RectTransformUtility.RectangleContainsScreenPoint(rectThree, Input.mousePosition);
                    if (curLevThreeDiaInx < levelThreeDiagueTextList.Count - 1)
                    {
                        if (mouseOnDiaThree)
                        {
                            curLevThreeDiaInx++;
                            levelThreeDiagueText.GetComponent<TMPro.TextMeshProUGUI>().text = levelThreeDiagueTextList[curLevThreeDiaInx];
                        }
                    }
                    else
                    {
                        if (mouseOnDiaThree)
                        {
                            LoadThirdLevel();
                        }
                    }
                }
            }
        }
    }


    public void SkipDia() //What happens after clicking skip button on dialogue panel
    {
        if (!IsMainDiaFinished) //clicked skip button on main dia
        {
            curDiaInx = dialogueTextList.Count - 1;
            IsMainDiaFinished = true;
            ChooseLevel();

            //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(chooseLevelFirstButton);
        }
        else if (SelectedLevelOne) //clicked skip button on level one dia
        {
            curLevOneDiaInx = levelOneDiagueTextList.Count - 1;
            LoadFirstLevel();
        }
        else if (SelectedLevelTwo) //clicked skip button on level two dia
        {
            curLevTwoDiaInx = levelTwoDiagueTextList.Count - 1;
            LoadSecondLevel();
        }
        else //clicked skip button on level three dia
        {
            curLevThreeDiaInx = levelThreeDiagueTextList.Count - 1;
            LoadThirdLevel();
        }
    }


    public void ChooseLevel()
    {
        //after Npc talks, active level panel
        if (dialoguePanel != null)
        {
            dialoguePanel.gameObject.SetActive(false);
        }
        if (GameOverPanel != null)
        {
            GameOverPanel.gameObject.SetActive(false);
        }
        levelPanel.gameObject.SetActive(true);

        
        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(chooseLevelFirstButton);
    }

    public void ChoosedLevelOne()
    {
        SelectedLevelOne = true;
        levelOneDiaguePanel.gameObject.SetActive(true);
        levelPanel.gameObject.SetActive(false);

        
        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(level1FirstDialogueButton);
    }

    public void ChoosedLevelTwo()
    {
        SelectedLevelTwo = true;
        levelTwoDiaguePanel.gameObject.SetActive(true);
        levelPanel.gameObject.SetActive(false);
    }

    public void ChoosedLevelThree()
    {
        SelectedLevelThree = true;
        levelThreeDiaguePanel.gameObject.SetActive(true);
        levelPanel.gameObject.SetActive(false);
    }

    public void LoadFirstLevel()
    {
        //load scene based on oreder of building settings
        Time.timeScale = 1;
        SceneManager.LoadScene(FirstlevelOrder);
    }

    public void LoadSecondLevel()
    {
        //load scene based on oreder of building settings
        Time.timeScale = 1;
        SceneManager.LoadScene(SecondlevelOrder);
    }

    public void LoadThirdLevel()
    {
        //load scene based on oreder of building settings
        Time.timeScale = 1;
        SceneManager.LoadScene(ThirdLevelOrder);
    }

 public void CallPauseButton()
    {
        //active pause panel after pressing pause button        
         
        if (pauseButton != null)
        {
            pauseButton.gameObject.SetActive(false);
        }
        pausePanel.gameObject.SetActive(true);
        Time.timeScale = 0;
        AudioListener.pause = true;       
        
        // clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);
         
    }

    public void CallPause(InputAction.CallbackContext context)
    {
        //active pause panel after pressing pause button with gamepad
         if (context.performed)
         {
        if (pauseButton != null)
        {
            pauseButton.gameObject.SetActive(false);
        }
        pausePanel.gameObject.SetActive(true);
        Time.timeScale = 0;
        AudioListener.pause = true;

        // clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);
         }
    }

    
    public void CallResume()
    {
        //disactive pause panel after clicking resume button on pause panel
        if (pauseButton != null)
        {
            pauseButton.gameObject.SetActive(true);
        }
        pausePanel.gameObject.SetActive(false);
        Time.timeScale = 1;
        AudioListener.pause = false;
    }

    public void CallBackToMain()
    {
        //back to main scene after clicking Back to main button on pause panel
        Time.timeScale = 1;
        pausePanel.gameObject.SetActive(false);
        SceneManager.LoadScene(MainSceneOrder);
         //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(menuPlayButton);
    }

    public void CallBackToMenu()
    {
        //back to menu scene for menu button
        SceneManager.LoadScene(MainSceneOrder);
          EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(menuPlayButton);
    }

    public void ActivateGameOverPanel()
    {
        Time.timeScale = 0;
        if (pauseButton != null)
        {
            pauseButton.gameObject.SetActive(false);
        }
        GameOverPanel.gameObject.SetActive(true);

        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set new selected object
        EventSystem.current.SetSelectedGameObject(gameoverFirstButton);
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
