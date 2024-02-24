using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused == false){
                Time.timeScale = 0;
                isPaused = true;
                Cursor.visible = true;
                this.GetComponent<AudioSource>().Pause();
                pauseMenu.SetActive(true);
            }
            else{
                Time.timeScale = 1;
                isPaused = false;
                Cursor.visible = false;
                this.GetComponent<AudioSource>().UnPause();
                pauseMenu.SetActive(false);
            }
        }
    }

    public void ResumeGame(){
        Time.timeScale = 1;
        isPaused = false;
        Cursor.visible = false;
        this.GetComponent<AudioSource>().UnPause();
        pauseMenu.SetActive(false);
    }

    public void RestartGame(){
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void QuitGame(){
        Time.timeScale = 1;
        GlobalLevel.levelNumber = 3;
        GlobalCoins.coins = 0;
        SceneManager.LoadScene(1);
    }
}
