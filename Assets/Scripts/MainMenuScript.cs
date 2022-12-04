using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void loadScene(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }

    public void exitGame() {
        Application.Quit();
    }
    
    public static bool isPaused = false;

    public void Pause() {
        print("Pause ran");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume() {
        print("resume ran");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Update() 
    {
        print("does update even work?");
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                Resume();
            }
            else {
                Pause();
            }
        }
    }
}
