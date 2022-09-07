using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    GameObject clearText;
    // Start is called before the first frame update
    void Start()
    {
        clearText = GameObject.Find("GameClear");
        clearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            clearText.SetActive(true);
            Time.timeScale = 0;            
        }
    }
}
