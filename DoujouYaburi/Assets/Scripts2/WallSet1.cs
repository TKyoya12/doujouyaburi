using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSet1 : MonoBehaviour
{
    [SerializeField] Sprite wall1;
    [SerializeField] Sprite wall2;
    [SerializeField] Sprite wall3;
    [SerializeField] Sprite wall4;
    [SerializeField] Sprite wall5;

    [SerializeField] int angle;     //1Å`6
    [SerializeField] int radius;    //1Å`

    Transform Transform;
    BoxCollider2D Collider2D;
    SpriteRenderer spriteRenderer;

    Vector3 position;
    float root3 = Mathf.Sqrt(3);
    float x = 0;
    float y = 0;
    float z = 0;

    void Awake()
    {
        if (angle == 1 || angle == 4)
        {
            x = 0;
        }
        else if (angle == 2 || angle == 3)
        {
            x = root3;
        }
        else if (angle == 5 || angle == 6)
        {
            x = -root3;
        }

        if (angle == 1)
        {
            y = 2;
        }
        else if (angle == 2 || angle == 6)
        {
            y = 1;
        }
        else if (angle == 3 || angle == 5)
        {
            y = -1;
        }
        else if(angle == 4)
        {
            y = -2;
        }

        x *= radius * 4;
        y *= radius * 4;
    }

    void Start()
    {
        Transform = GetComponent<Transform>();
        Collider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        position = new Vector3(x, y, z);

        transform.localPosition = position;
        transform.rotation = Quaternion.Euler(0f, 0f, (angle - 1) * -60f);
        Collider2D.size = new Vector2(radius * 8 + 1,1);
        switch (radius)
        {
            case 1:
                spriteRenderer.sprite = wall1;
                break;
            case 2:
                spriteRenderer.sprite = wall2;
                break;
            case 3:
                spriteRenderer.sprite = wall3;
                break;
            case 4:
                spriteRenderer.sprite = wall4;
                break;
            case 5:
                spriteRenderer.sprite = wall5;
                break;
        }
    }
}
