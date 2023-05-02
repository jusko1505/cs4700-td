using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverScript : MonoBehaviour
{
    public string mainMenuScene = "MainMenu";
    
    /* script that should contain what the buttons on the main menu screen should do */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onRetry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("retry");
    }

    public void onMainMenu(){
        SceneManager.LoadScene(mainMenuScene);
        Debug.Log("Going to menu");
    }
}
