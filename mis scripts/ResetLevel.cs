using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    public static void resetScene()
    {
        LifeManager.lifes = 5;
        LifeManager.endSignal = false;
        DamagePlayer.cleared = false;
        ScoreManager.failed = false;
        ScoreManager.resetScore();
    }
}
