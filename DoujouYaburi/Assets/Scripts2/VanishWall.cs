using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishWall : MonoBehaviour
{
    [SerializeField] Item.ItemType type;
    [SerializeField] PlayerScript player;

    bool item = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (type)
            {
                case Item.ItemType.A:
                    item = player.gotA;
                    break;
                case Item.ItemType.B:
                    item = player.gotB;
                    break;
                case Item.ItemType.C:
                    item = player.gotC;
                    break;
            }

            if (item && Input.GetKey(KeyCode.Space))
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
