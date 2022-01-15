using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeCadre : Monster
{
    bool attacking;

    int damage;
    int stack;
    void Start()
    {
        hp = 60;
        attacking = false;
        speed = 0.6f;
        player2 = GameObject.Find("Player2");
        damage = 3;
        stack = 0;
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
        if (stack != 0 && stack % 3 == 0) damage = 4;
        else damage = 3;
        player.player2Hp -= damage;
        print("공격");
        stack++;
        yield return new WaitForSeconds(1f); // 공속
        attacking = false;
    }
}
