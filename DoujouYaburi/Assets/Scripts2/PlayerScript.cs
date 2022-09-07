using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // �R���|�[�l���g�ۑ��p�ϐ�
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Animator animator;

    // ����J�ϐ�
    float speed = 0f;
    float moveSpeedH = 0;
    float moveSpeedV = 0;

    //�C���X�y�N�^�\���ϐ�
    [SerializeField] Sprite empty;
    [SerializeField] Sprite holding;
    [SerializeField] float defaultSpeed = 3;
    [SerializeField] float dashSpeed = 5;



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
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeedV = 0;
        moveSpeedH = 0;
        //animator.SetBool("Bool",false);


        if (Input.GetKey(KeyCode.W))
        {
            moveSpeedV = speed;
            //animator.SetBool("Bool", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveSpeedV = -speed;
            animator.SetBool("Bool", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveSpeedH = -speed;
            animator.SetBool("Bool", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveSpeedH = speed;
            animator.SetBool("Bool", true);
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
        //if(gotA || gotB || gotC)
        //{
        //    spriteRenderer.sprite = holding;
        //}
        //else
        //{
        //    spriteRenderer.sprite = empty;
        //}
    }
}
