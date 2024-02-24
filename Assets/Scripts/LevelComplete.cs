using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int importedCoins;
    public GameObject completedText;
    public GameObject fadeOut;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        importedCoins = GlobalCoins.coins;
        if(importedCoins == 5){
            StartCoroutine(LevelCompleted());
        }
    }

    IEnumerator LevelCompleted()
    {
        yield return new WaitForSeconds(0.2f);
        completedText.SetActive(true);
        fadeOut.SetActive(true);
        player.GetComponent<PlayerControls>().enabled = false;
        yield return new WaitForSeconds(3);
        GlobalLevel.levelNumber += 1;
        if(GlobalLevel.levelNumber != 6){
            PlayerPrefs.SetInt("SavedLevel", GlobalLevel.levelNumber);
            SceneManager.LoadScene(2);
        }
        else{
            GlobalLevel.levelNumber = 3;
            GlobalCoins.coins = 0;
            PlayerPrefs.SetInt("SavedLevel", 3);
            SceneManager.LoadScene(1);
        }
    }
}
