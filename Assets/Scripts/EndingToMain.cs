using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingToMain : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(End());
    }

    void Update()
    {
        
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Start_Scene");
    }
}
