using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearLevel : MonoBehaviour
{ 
    private bool isClear = false;
    public GameObject next;
    public int tagScene = 0;
    private float timeAcum = 10;
    public TMP_Text prepareNext = null;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && isClear == true)
        {
            next.SetActive(true);
            gameObject.GetComponent<AudioSource>().Play();
            DamagePlayer.cleared = true;
        }
    }
    private void Update()
    {
        if (gameObject.transform.childCount == 0) 
        { 
            isClear = true;
            if (DamagePlayer.cleared)
            {
                timeAcum -= Time.deltaTime;
                prepareNext.text = "Siguiente Nivel en " + (int)timeAcum;
                if (timeAcum < 0)
                {
                    ResetLevel.resetScene();
                    SceneManager.LoadScene(tagScene);
                }
            }
        }
        else { next.SetActive(false); }
    }
}
