using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int minutes = 1;
    int seconds = 70;
    [SerializeField] float timer = 0;
    
    GameObject GOMinutes;
    GameObject GOSeconds;
    // Start is called before the first frame update
    void Start()
    {
        GOMinutes = GameObject.Find("Minutes");
        GOSeconds = GameObject.Find("Seconds");
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SceneManager.LoadScene("ResultScene2");
        }
        minutes = (int)timer / 60;
        seconds = (int)timer - (minutes * 60);
        GOMinutes.GetComponent<Text>().text = minutes.ToString("F0").PadLeft(2, '0'); ;
        GOSeconds.GetComponent<Text>().text = seconds.ToString("F0").PadLeft(2, '0'); ;
    }
}

