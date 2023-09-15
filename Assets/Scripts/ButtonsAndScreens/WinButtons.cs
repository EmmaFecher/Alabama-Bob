using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButtons : MonoBehaviour
{
    public PlayerMovement hasDonut;
    public GameObject winScreen;
    public string mainMenuScene;
    // Start is called before the first frame update
    void Start()
    {
        hasDonut = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasDonut.hasDonut == true)
        {
            //turn on win screen
            winScreen.SetActive(true);
            //pause game (for boss)
            Time.timeScale = 0f;
        }
        else
        {
            winScreen.SetActive(false);
            Time.timeScale = 1f;
        }
    }


    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

}
