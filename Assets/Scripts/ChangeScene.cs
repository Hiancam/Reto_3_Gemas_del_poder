using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int tagScene = 0;
    public static int retryScene = 0;
    public void loadScene()
    {
        if(retryScene != 0 && tagScene != 0)
            SceneManager.LoadScene(retryScene);
        else SceneManager.LoadScene(tagScene);
        retryScene = 0;
    }
}
