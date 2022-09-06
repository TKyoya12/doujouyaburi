using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSet : MonoBehaviour
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
        position = new Vector3(x, y, z);

        transform.localPosition = position;
    }
}
