using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedMonster : Monster
{
    bool attacking;
    public GameObject bullet;
    void Start()
    {
        hp = 5;
        attacking = false;
        speed = 0.5f;
        player2 = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player2.transform.position, speed * Time.deltaTime);
        if (Mathf.Abs(Vector3.Distance(transform.position, player2.transform.position)) < 8f)
        {
            speed = 0;
            if (attacking == false)
            {
                StartCoroutine(attack());
            }
        }
        else speed = 0.5f;

        death();
    }

    IEnumerator attack()
    {
        attacking = true;
        yield return new WaitForSeconds(0.2f);
        CharacterController player = GameObject.Find("GameManager").GetComponent<CharacterController>();
        player.player2Hp -= 1;
        GameObject bulletGO = Instantiate(bullet);
        bulletGO.transform.position = transform.position;
        yield return new WaitForSeconds(3f); // °ø¼Ó
        attacking = false;
    }
}
