using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    // �I�u�W�F�N�g
    [SerializeField] GameObject retryButton;

    // ���J�ϐ�
    public bool clear = true;

    void Start()
    {
        retryButton.SetActive(!clear);
    }

    void Update()
    {
        
    }
}
