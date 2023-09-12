using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal: MonoBehaviour
{
    AudioSource sonido;
    void Start()
    {
        sonido = GetComponent<AudioSource>();
        GetComponent<MeshRenderer>().enabled = true;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && !ScoreManager.failed)
        {
            sonido.Play();
            ScoreManager.SumScore(1);
            GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject, 0.5f);
        }
    }
}
