using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    [SerializeField] string sceneName;

    public void ClickCalled()
    {
        SceneManager.LoadScene(sceneName);
    }

}
