using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    // オブジェクト
    [SerializeField] GameObject retryButton;

    // 公開変数
    public bool clear = true;

    void Start()
    {
        retryButton.SetActive(!clear);
    }

    void Update()
    {
        
    }
}
