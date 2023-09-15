using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loose : MonoBehaviour
{
    public PlayerMovement hitBoss;
    public GameObject looseScreen;
    public string mainMenuScene;
    // Start is called before the first frame update
    void Start()
    {
        hitBoss = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hitBoss.hitBoss == true)
        {
            Time.timeScale = 0f;
            looseScreen.SetActive(true);
            
        }
        else
        {
            looseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
    }


    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

}
