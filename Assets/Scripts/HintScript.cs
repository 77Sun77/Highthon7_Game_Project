using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(activeFalse());
    }
    IEnumerator activeFalse()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
