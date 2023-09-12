using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    //La primera posición del arreglo se deja en 0,
    //el resto guarda el puntaje según el nivel. 
    public static float[] timeList = new float[4];
    public static float milliseconds;
	public TMP_Text timing;
    public static bool paused;
    private static int currentIndex;

    public void Start()
	{
		milliseconds = 0.0f;
        timing.text = "0.00";
        paused = false;
    }

    public static string getTotalTime()
    {
        float total = 0.0f;
        for (int u = 0; u < timeList.Length; u++)
            total += timeList[u];
        return "Tiempo: " + ((int)total / 60) + "." + ((int)total % 60).ToString("D2");
    }

    public void Update()
	{
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex <= timeList.Length && !paused) 
        {
            milliseconds += 0.05f;
            timeList[currentIndex] = milliseconds;
            string seconds = "" + ((int)milliseconds % 60).ToString("D2");
            string minutes = "" + (int)milliseconds / 60;
            timing.text = "Tiempo: " + minutes + "." + seconds;
        }
        else timing.text = "Tiempo Total: " + getTotalTime();
    }
}