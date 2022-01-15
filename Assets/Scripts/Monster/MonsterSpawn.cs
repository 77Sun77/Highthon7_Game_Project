using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject basicMonster;
    public GameObject rangedMonster;
    public GameObject batMonster;

    public GameObject[] space;

    CharacterController c1;
    void Start()
    {
        StartCoroutine(monsterSpawn());
        c1 = GameObject.Find("GameManager").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(c1.player2.transform.position.x + 10.3f, transform.position.y);
    }

    IEnumerator monsterSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(15f);
            int random = Random.Range(0, 3);
            switch (random)
            {
                case 0:
                    GameObject GO = Instantiate(basicMonster);
                    GO.transform.position = space[0].transform.position;
                    break;
                case 1:
                    GO = Instantiate(rangedMonster);
                    GO.transform.position = space[1].transform.position;
                    break;
                case 2:
                    GO = Instantiate(batMonster);
                    GO.transform.position = space[2].transform.position;
                    break;
            }
        }
    }
}
