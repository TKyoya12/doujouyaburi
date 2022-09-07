using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWord : MonoBehaviour
{
    [SerializeField]GameObject word;
    GameObject cube;
    bool isWord = false;
    bool isPlayer = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isWord)
        {
            isWord = true;
            Invoke("WordSpawn", 1.0f);
        }
        if (isPlayer)
        {

            if (Input.GetKeyDown(KeyCode.Space) && isWord)
            {
                DestroyWord();
                Debug.Log("des");
            }
        }
        }
        public void DestroyWord()
    {
        Destroy(cube);
        isWord = false;
    }
    public void WordSpawn()
    {
        cube = Instantiate(word, this.transform.position, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayer = false;
        }
    }


}
