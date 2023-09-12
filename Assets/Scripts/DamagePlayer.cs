using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer: MonoBehaviour
{
    public static bool damageSignal = false;
    public static float damageTime = 0f;
    public static bool cleared = false;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && !cleared)
        {
            damageSignal = true;
            damageTime = 0f;
            gameObject.GetComponent<AudioSource>().Play();
            if (!LifeManager.endSignal) LifeManager.lifes -= 1;
        }
    }
}
