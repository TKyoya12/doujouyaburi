using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    void Start()
    {
        Invoke("OnCompleteAnimation",0.4f);
    }


    void OnCompleteAnimation()
    {
        Destroy(this.gameObject);
    }
}
