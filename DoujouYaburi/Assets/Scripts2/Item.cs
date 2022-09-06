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
    [SerializeField] PlayerScript player;
    [SerializeField] GameObject effect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switch(type)
            {
            case ItemType.A:
                    player.gotA = true;
                    break;
            case ItemType.B:
                    player.gotB = true;
                    break;
            case ItemType.C:
                    player.gotC = true;
                    break;
                  
            }
            Instantiate(effect,
                this.transform.position,
                this.transform.rotation);
            this.gameObject.SetActive(false);
        }
    }
}
