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
        ProblemKinds.stack = 0;
        Bunpil.two = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Shutter.stack == 1 && boss1)
        {
            GameObject Go = Instantiate(boss[0]);
            Go.transform.position = space[0].position;
            boss1 = false;
            MonsterSpawn.isSpawn = false;
        }

        if(Bunpil.two && boss2)
        {
            GameObject Go = Instantiate(boss[1]);
            Go.transform.position = space[1].position;
            boss2 = false;
            MonsterSpawn.isSpawn = false;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (boss3 && Input.GetKeyDown(KeyCode.F))
        {
            GameObject Go = Instantiate(boss[2]);
            Go.transform.position = space[2].position;
            boss3 = false;
            MonsterSpawn.isSpawn = false;
        }
    }
}
