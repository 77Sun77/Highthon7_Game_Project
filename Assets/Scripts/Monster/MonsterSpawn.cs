using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject basicMonster;
    public GameObject rangedMonster;
    public GameObject batMonster;
    void Start()
    {
        StartCoroutine(monsterSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator monsterSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            int random = Random.Range(0, 3);
            switch (random)
            {
                case 0:
                    Instantiate(basicMonster);
                    break;
                case 1:
                    Instantiate(rangedMonster);
                    break;
                case 2:
                    Instantiate(batMonster);
                    break;
            }
        }
    }
}
