using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoCadre : Monster
{
    bool attacking;
    int maxHp = 40;

    float timer;
    void Start()
    {
        hp = 40;
        attacking = false;
        speed = 0.6f;
        player2 = GameObject.Find("Player2");
        timer = 0.0f;

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

        if(hp > maxHp)
        {
            hp = maxHp;
        }

        timer += Time.deltaTime;

        if (timer > 5)
        {
            hp += 2;
            print("Èú ÀÌÆÑÆ®");
            timer = 0;
        }

        if (hp <= 0) MonsterSpawn.isSpawn = true;

        death();
    }

    IEnumerator attack()
    {
        attacking = true;
        yield return new WaitForSeconds(0.2f);
        CharacterController player = GameObject.Find("GameManager").GetComponent<CharacterController>();
        player.player2Hp -= 2;
        print("°ø°Ý");
        yield return new WaitForSeconds(5f); // °ø¼Ó
        attacking = false;
    }
}
