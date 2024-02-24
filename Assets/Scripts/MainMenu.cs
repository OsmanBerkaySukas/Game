using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int loadGame;
    public Text hintText;
    public int hintNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        hintNumber = Random.Range(1, 5);
        if(hintNumber == 1){
            hintText.text = "Press 'ESC' to pause the game.";
        }
        if(hintNumber == 2){
            hintText.text = "Collect all 5 coins to complete the level.";
        }
        if(hintNumber == 3){
            hintText.text = "Don't let time run out!";
        }
        if(hintNumber == 4){
            hintText.text = "Don't crash into the obstacles and walls!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        GlobalLevel.levelNumber = 3;
        PlayerPrefs.SetInt("SavedLevel", GlobalLevel.levelNumber);
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

    public void LoadGame(){
        loadGame = PlayerPrefs.GetInt("SavedLevel");
        if (loadGame < 3){
            SceneManager.LoadScene(GlobalLevel.levelNumber);
        }
        else{
            GlobalLevel.levelNumber = loadGame;
            SceneManager.LoadScene(loadGame);
        }
    }

    public void QuitGame(){
        Application.Quit();
    }
}
