using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWord : MonoBehaviour
{
    [SerializeField]GameObject word;
    GameObject cube;
    public bool isWord = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!isWord)
        {
            isWord = true;
            Invoke("spawnWord", 1.0f);
        }
        if(Input.GetKeyDown(KeyCode.Space) && isWord)
        {
            destroyWord();
        }
    }
    public void destroyWord()
    {
        Destroy(cube);
        isWord = false;
        Debug.Log("destroy");
    }
    public void spawnWord()
    {
        cube = Instantiate(word, this.transform.position, Quaternion.identity);
    }
}
