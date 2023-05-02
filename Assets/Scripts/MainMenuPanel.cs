using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPanel : MonoBehaviour
{
    public string levelSelectSceneName = "LevelSelect";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene(levelSelectSceneName);
        Debug.Log("Start");
    }

    public void ExitGame(){
        Debug.Log("Exiting");
        Application.Quit();
    }
}
