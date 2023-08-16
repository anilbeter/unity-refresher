using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;

    public float reloadDelay = 1.5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finishEffect.Play();
            Invoke(nameof(ReloadScene), reloadDelay);
        }


    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
