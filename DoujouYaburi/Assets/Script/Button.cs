using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] Sprite nomal;
    [SerializeField] Sprite select;
    [SerializeField] Sprite press;
    Vector2 size;
    Vector2 BPos;       //ボタンの座標
    Vector2 MPos;       //マウスの座標
    bool isInButton = false;    //true…ボタンの中, false…ボタンの外
    bool isPressed = false;     
    RectTransform rect;
    Image ima;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        ima = GetComponent<Image>();
        size = rect.sizeDelta;
        BPos = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        isInButton = false;
        MPos = Input.mousePosition;
        if (MPos.x >= BPos.x - size.x / 2)
        {
            if (MPos.x <= BPos.x + size.x / 2)
            {
                if (MPos.y <= BPos.y + size.y / 2)
                {
                    if (MPos.y >= BPos.y - size.y / 2)
                    {
                        isInButton = true;
                        
                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
        }
        if (isPressed)
        {
            ima.sprite = press;
        }
        else
        {
            if (isInButton)
            {
                ima.sprite = select;
            }
            else
            {
                ima.sprite = nomal;
            }
        }
        
    }
}
