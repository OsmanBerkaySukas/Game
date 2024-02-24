using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalCoins.coins = 0;
        if(GlobalLevel.levelNumber == 6){
            SceneManager.LoadScene(1);
        }
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
