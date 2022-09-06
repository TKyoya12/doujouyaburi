using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float minutes = 1;
    [SerializeField] float seconds = 10;
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
        if (minutes == 0)
        {
            
        }
        if (seconds <= 0)
        {
            minutes--;
            seconds = 59;
        }
        else
        {
            seconds -= Time.deltaTime;
        }
        GOMinutes.GetComponent<Text>().text = minutes.ToString("F0").PadLeft(2, '0'); ;
        GOSeconds.GetComponent<Text>().text = seconds.ToString("F0").PadLeft(2, '0'); ;
    }
}

