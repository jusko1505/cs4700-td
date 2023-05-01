using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;

    public GameObject gameOverUI;
    public GameObject levelCompleteUI;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerResources.Lives <= 0){
            setGameOverUI();
        }
    }

    void setGameOverUI(){
        gameOver = true;
        gameOverUI.SetActive(true);
    }

    void setLevelCompleteUI(){
        gameOver = true;
        levelCompleteUI.SetActive(true);
    }
}
