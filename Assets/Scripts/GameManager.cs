using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hint;
    public bool boss1, boss2, boss3;

    public GameObject[] boss;
    public Transform[] space;
    public void hintTrue()
    {
        hint.SetActive(true);
    }
    void Start()
    {
        boss1 = true;
        boss2 = true;
        boss3 = true;
        Shutter.stack = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Shutter.stack == 1 && boss1)
        {
            GameObject GO = Instantiate(boss[0]);
            GO.transform.position = space[0].position;
            MonsterSpawn.isSpawn = false;
            boss1 = false;
        }
    }
}
