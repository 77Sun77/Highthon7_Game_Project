using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMonster : Monster
{
    bool attacking;
    void Start()
    {
        hp = 15;
        attacking = false;
        speed = 1;
        player2 = GameObject.Find("Player2");


        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player2.transform.position, speed * Time.deltaTime);
        if (Mathf.Abs(Vector3.Distance(transform.position, player2.transform.position)) < 2.5f)
        {
            speed = 0;
            if (attacking == false)
            {
                StartCoroutine(attack());
            }
        }
        else speed = 1;


        if (player2.transform.position.x < transform.position.x)
        {
            sprite.flipX = true;
        }
        else sprite.flipX = false;

        death();
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
