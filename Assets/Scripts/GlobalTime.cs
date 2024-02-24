using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour
{
    public Text timeDisplay;
    public int seconds = 30;
    public bool deductingTime;
    public GameObject outOfTimeText;
    public GameObject fadeOut;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(seconds == 0){
            player.GetComponent<PlayerControls>().enabled = false;
            outOfTimeText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RestartLevel());
        }
        else{
            if(deductingTime == false){
                deductingTime = true;
                StartCoroutine(DeductSecond());
            }
        }
    }

    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDisplay.text = "Time: " + seconds;
        deductingTime = false;
    }

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}
