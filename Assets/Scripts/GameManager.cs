using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hint;
    public bool boss1, boss2, boss3;
    public void hintTrue()
    {
        hint.SetActive(true);
    }
    void Start()
    {
        boss1 = false;
        boss2 = false;
        boss3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
