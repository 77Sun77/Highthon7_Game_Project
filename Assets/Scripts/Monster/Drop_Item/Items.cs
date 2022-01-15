using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public static bool isHint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHint) StartCoroutine(hintDestroy());
    }

    IEnumerator hintDestroy()
    {
        yield return new WaitForSeconds(5f);
    }
}
