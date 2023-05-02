using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPanel : MonoBehaviour
{
    public string firstLevel = "FirstLevel";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene(firstLevel);
        Debug.Log("Start");
    }

    public void ExitGame(){
        Debug.Log("Exiting");
        Application.Quit();
    }
}
