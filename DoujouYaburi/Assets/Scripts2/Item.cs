using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        A,
        B,
        C
    }

    [SerializeField] ItemType type;
    [SerializeField] GameObject effect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            /*
            Instantiate(effect,
                this.transform.position,
                this.transform.rotation);
            this.gameObject.SetActive(false);*/
        }
    }
}
