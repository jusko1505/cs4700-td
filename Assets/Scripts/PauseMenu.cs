using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string mainMenuScene = "MainMenu";
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            OnPause();
            Debug.Log("esc pressed!");
        }
    }

    void OnPause(){
        if(pausePanel.activeSelf){
            pausePanel.SetActive(false);
            Debug.Log("unsetting pause panel");
        }
        else{
            pausePanel.SetActive(true);
            Debug.Log("setting pause panel");
        }
        //pausePanel.SetActive(!pausePanel.activeSelf);

        if (pausePanel.activeSelf){
            Time.timeScale = 0f;

        }
        else{
            Time.timeScale = 1f;
        }
    }

    public void OnRestart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("retry");
    }

    public void OnMainMenu(){
        Debug.Log("Going to menu");
        SceneManager.LoadScene(mainMenuScene);
    }
}
