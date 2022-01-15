using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditBg : MonoBehaviour
{
    Image bt;

    void Start()
    {
        bt = GetComponent<Image>();
        StartCoroutine(ButtonPress());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ButtonPress()
    {
        yield return new WaitForSeconds(1f);
        bt.color = new Color(157/255f, 106 / 255f, 106 / 255f, 255/255f);
        yield return new WaitForSeconds(0.5f);
        bt.color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
        StartCoroutine(ButtonPress());
    }


}
