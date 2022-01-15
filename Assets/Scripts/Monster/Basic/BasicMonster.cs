using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMonster : Monster
{
    bool attacking;
    void Start()
    {
        hp = 10;
        attacking = false;
        speed = 1;
        player2 = GameObject.Find("Player2");
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player2.transform.position, speed * Time.deltaTime);
        if (Mathf.Abs(Vector3.Distance(transform.position, player2.transform.position)) < 1.5f)
        {
            speed = 0;
            if (attacking == false)
            {
                StartCoroutine(attack());
            }
        }
        else speed = 1;
    }

    IEnumerator attack()
    {
        attacking = true;
        yield return new WaitForSeconds(0.2f);
        CharacterController player = GameObject.Find("GameManager").GetComponent<CharacterController>();
        player.player2Hp -= 1;
        print("공격");
        yield return new WaitForSeconds(1f); // 공속
        attacking = false;
    }
}
