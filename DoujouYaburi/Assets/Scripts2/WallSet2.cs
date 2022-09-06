using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSet2 : MonoBehaviour
{
    [SerializeField] int angle;     //1Å`6
    [SerializeField] int radius;    //1Å`

    Transform Transform;
    Vector3 position;

    float root3 = Mathf.Sqrt(3);
    float x = 0;
    float y = 0;
    float z = 0;

    void Awake()
    {
        if (angle == 1 || angle == 3)
        {
            x = 1;
        }
        else if (angle == 2)
        {
            x = 2;
        }
        else if (angle == 4 || angle == 6)
        {
            x = -1;
        }
        else if(angle == 5)
        {
            x = -2;
        }

        if (angle == 1 || angle == 6)
        {
            y = root3;
        }
        else if (angle == 2 || angle == 5)
        {
            y = 0;
        }
        else if (angle == 3 || angle == 4)
        {
            y = -root3;
        }

        x *= radius * 4 + 3;
        y *= radius * 4 + 3;
    }

    void Start()
    {
        Transform = GetComponent<Transform>();
        position = new Vector3(x, y, z);

        transform.localPosition = position;
        transform.rotation = Quaternion.Euler(0f, 0f, angle * -60f + 120);
    }
}
