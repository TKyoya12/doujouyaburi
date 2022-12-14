using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // コンポーネント保存用変数
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Animator animator;

    // 非公開変数
    float speed = 0f;
    float moveSpeedH = 0;
    float moveSpeedV = 0;

    //インスペクタ表示変数
    [SerializeField] Sprite empty;
    [SerializeField] Sprite holding;
    [SerializeField] float defaultSpeed = 3;
    [SerializeField] float dashSpeed = 5;


    //[SerializeField] GameObject itemEffect;


    // 公開変数
    public bool gotA = false;  //アイテムAを手に入れたか
    public bool gotB = false;  //アイテムBを手に入れたか
    public bool gotC = false;  //アイテムCを手に入れたか

    // Start is called before the first frame update
    void Start()
    {
        // Getcompornent
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeedV = 0;
        moveSpeedH = 0;


        if (Input.GetKey(KeyCode.W))
        {
            moveSpeedV = speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveSpeedV = -speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveSpeedH = -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveSpeedH = speed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = dashSpeed;
        }
        else
        {
            speed = defaultSpeed;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveSpeedH, moveSpeedV);
    }

    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("a");
    //    if (!gotA && !gotB && !gotC)
    //    {
    //        switch (collision.gameObject.tag)
    //        {
    //            default:
    //                break;
    //            case "ItemA":
    //                gotA = true;
    //                break;
    //            case "ItemB":
    //                gotB = true;
    //                break;
    //            case "ItemC":
    //                gotC = true;
    //                break;
    //        }
    //        Instantiate(itemEffect,
    //            collision.transform.position,
    //            collision.transform.rotation);
    //        Destroy(collision.gameObject);
    //    }
    //}
}
