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
        isPaused = true;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Resume() {
        isPaused = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() 
    {
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
