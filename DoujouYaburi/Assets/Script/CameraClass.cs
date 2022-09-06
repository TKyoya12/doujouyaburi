using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClass : MonoBehaviour
{
    Camera cam;
    Vector3 CameraPosition;

    [SerializeField] GameObject target; // í«è]Ç∑ÇÈëŒè€ÇåàÇﬂÇÈ
    [SerializeField] float[] zoom = new float[3];
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        //
        //StartCoroutine(Shake(5.0f, 0.05f));
        cam = this.gameObject.GetComponent<Camera>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            count++;
            if (count > zoom.Length - 1)
                count = zoom.Length - 1;
            cam.orthographicSize = zoom[count];
        }
        if (Input.GetMouseButtonDown(1))
        {
            count--;
            if(count < 0)
                count = 0;
            cam.orthographicSize = zoom[count];
        }
        CameraPosition.x = target.transform.position.x;
        CameraPosition.z = -10; // ÉJÉÅÉâÇÃâúçsÇ´ÇÃà íuÇ…-10Çì¸ÇÍÇ»Ç¢Ç∆å©Ç¶ÇÒ
        CameraPosition.y = target.transform.position.y;
        Camera.main.gameObject.transform.position = CameraPosition;
        
    }
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPosition = transform.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            transform.position = originalPosition + Random.insideUnitSphere * magnitude;
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = originalPosition;
    }
}
