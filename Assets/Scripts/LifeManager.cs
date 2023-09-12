using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class LifeManager : MonoBehaviour
{
    public static int lifes = 5;
    public static bool endSignal = false;
    private float timeAcum = 10;
    public TMP_Text lifeText;
    public TMP_Text prepareRetry = null;
    public GameObject retry;

    void Update()
    {
        lifeText.text = "Vidas: " + lifes;
        
        if (lifes == 0)
        {
            endSignal = true;
            ScoreManager.failed = true;
            retry.SetActive(true);
            timeAcum -= Time.deltaTime;
            prepareRetry.text = "Reintentando en " + (int)timeAcum;
            if (timeAcum < 0)
            {
                ResetLevel.resetScene();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            //ChangeScene.retryScene = SceneManager.GetActiveScene().buildIndex;
        }
        else { retry.SetActive(false); }
    }
}
