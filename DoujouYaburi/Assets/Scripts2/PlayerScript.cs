using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // �R���|�[�l���g�ۑ��p�ϐ�
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    // ����J�ϐ�
    float axisH = 0;    //��
    float axisV = 0;    //�c
    float speed = 0f;
    float moveSpeedH = 0;
    float moveSpeedV = 0;

    //�C���X�y�N�^�\���ϐ�
    [SerializeField] float sizeH = 1f;
    [SerializeField] float sizeV = 1f;
    [SerializeField] Sprite empty;
    [SerializeField] Sprite holding;

    // ���J�ϐ�
    public bool gotA = false;  //�A�C�e��A����ɓ��ꂽ��
    public bool gotB = false;  //�A�C�e��B����ɓ��ꂽ��
    public bool gotC = false;  //�A�C�e��C����ɓ��ꂽ��

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
