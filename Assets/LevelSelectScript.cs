using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    public string FirstLevelSceneName = "FirstLevel";
    public string SecondLevelSceneName = "SecondLevel";
    public string mainMenuScene = "MainMenu";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape)){
            onMainMenu();
            Debug.Log("esc pressed!");
        }
    }

    public void onLevelSelect1(){
        SceneManager.LoadScene(FirstLevelSceneName);
        Debug.Log("Starting Level1");
    }

    public void onLevelSelect2(){
        SceneManager.LoadScene(SecondLevelSceneName);
        Debug.Log("Starting Level2");
    }

    public void onMainMenu(){
        SceneManager.LoadScene(mainMenuScene);
    }

  
}
