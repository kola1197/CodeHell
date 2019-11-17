using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class MainMenu : MonoBehaviour
{
    public GameObject dialogueWindow;
    public void StartNewGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OpenDialogueWindow()
    {
        dialogueWindow.SetActive(true);
    }
    
    public void CloseDialogueWindow()
    {
        dialogueWindow.SetActive(false);
    }
}
