using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Ground")
        {
            //Debug.Log("WTF!");
            //SceneManager.LoadScene(0);
            Invoke("ReloadScene",delay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
