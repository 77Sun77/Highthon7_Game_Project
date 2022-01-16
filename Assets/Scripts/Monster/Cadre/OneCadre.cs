using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneCadre : Monster
{
    bool attacking;
    int maxHp = 40;

    float timer;

    int stack;
    Vector2 move;
    int rotate;

    public GameObject bullet;

    bool isMove;
    void Start()
    {
        hp = 20;
        attacking = false;
        speed = 0.6f;
        player2 = GameObject.Find("Player2");
        timer = 0.0f;

        sprite = GetComponent<SpriteRenderer>();

        stack = 0;

        isMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove) transform.position = Vector3.Lerp(transform.position, player2.transform.position, speed * Time.deltaTime);

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

        if (hp > maxHp)
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
        if(stack%2==1 || stack == 0) player.player2Hp -= 1;
        else
        {
            if (transform.position.x > player2.transform.position.x) move = new Vector2(transform.position.x + 6, transform.position.y);
            else move = new Vector2(transform.position.x - 6, transform.position.y);
            isMove = false;
            while (true)
            {
                yield return new WaitForFixedUpdate();
                transform.position = Vector3.Lerp(transform.position, move, 6 * Time.deltaTime);
                
                if (Mathf.Abs(Vector3.Distance(transform.position, move)) < 1)
                {
                    GameObject bulletGO = Instantiate(bullet);
                    bulletGO.transform.position = transform.position;
                    break;
                }
            }
            
            yield return new WaitForSeconds(1f);
            isMove = true;

        }
        print("°ø°Ý");
        stack++;
        yield return new WaitForSeconds(5f); // °ø¼Ó
        attacking = false;
    }
}
