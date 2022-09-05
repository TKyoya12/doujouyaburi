using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClass : MonoBehaviour
{
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Shake(5.0f, 0.05f));
        cam = this.gameObject.GetComponent<Camera>();
        cam.orthographicSize  = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
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
