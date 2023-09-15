using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtons : MonoBehaviour
{
    public string level;
    public GameObject directionScreen, creditScreen, pinkSlip;
    
    public void StartGame()
    {
        SceneManager.LoadScene(level);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenDirections()
    {
        directionScreen.SetActive(true);
        pinkSlip.SetActive(false);
    }
    public void CloseDirections()
    {
        directionScreen.SetActive(false);
        pinkSlip.SetActive(true);
    }
    public void OpenCredits()
    {
        creditScreen.SetActive(true);
        pinkSlip.SetActive(false);
    }
    public void CloseCredits()
    {
        creditScreen.SetActive(false);
        pinkSlip.SetActive(true);
    }

}
