using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // コンポーネント保存用変数
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    // 非公開変数
    float axisH = 0;    //横
    float axisV = 0;    //縦
    float speed = 0f;
    float moveSpeedH = 0;
    float moveSpeedV = 0;

    //インスペクタ表示変数
    [SerializeField] float sizeH = 1f;
    [SerializeField] float sizeV = 1f;
    [SerializeField] Sprite empty;
    [SerializeField] Sprite holding;

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
    }

    // Update is called once per frame
    void Update()
    {
        axisH = Input.GetAxisRaw("Horizontal");    
        axisV = Input.GetAxisRaw("Vertical");      

        if(!(axisH == 0))
        {
            transform.localScale = new Vector3(axisH * sizeH, 1f * sizeV, 1f);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5f;
        }
        else
        {
            speed = 3f;
        }

        moveSpeedH = axisH * speed;
        moveSpeedV = axisV * speed;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveSpeedH, moveSpeedV);
        if(gotA || gotB || gotC)
        {
            spriteRenderer.sprite = holding;
        }
        else
        {
            spriteRenderer.sprite = empty;
        }
    }
}
