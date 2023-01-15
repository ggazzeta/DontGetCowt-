using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject LevelSelection;
    public GameObject PlayOptions;
    public Animator myAnimator;

    void Start()
    {
        var animator = GetComponent<Animator>();
        PlayOptions.SetActive(false);
        LevelSelection.SetActive(false);
    }

    public void PlayGame()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            SceneManager.LoadScene("Tutorial");
        }
        else
        {
            SceneManager.LoadScene("TutorialPC");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void OpenPlayOptions()
    {
        myAnimator.SetBool("canLeave", false);
        PlayOptions.SetActive(true);
    }

    public void ClosePlayOptions()
    {
        myAnimator.SetBool("canLeave", true);
        PlayOptions.SetActive(false);
    }


    private static string _myTxtMsg;

    public static string LvlSelectionTxt
    {
        get { return _myTxtMsg.textNoAccessOutside(); }
        set { _myTxtMsg = value; }
    }


    public void OpenLevelSelection()
    {
        if(whichLevel.canPlay)
        {
            LevelSelection.SetActive(true);
        }
        else
        {
            whichLevel lvl = GameObject.FindWithTag("LevelSelector").GetComponent<whichLevel>();
            lvl.noAccessMsg(LvlSelectionTxt);
            Debug.Log("Nope");
        }

    }

    public void CloseLevelSelection()
    {
        LevelSelection.SetActive(false);
    }
}
