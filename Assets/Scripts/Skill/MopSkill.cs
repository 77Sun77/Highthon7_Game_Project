using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MopSkill : MonoBehaviour
{
    Monster monster;
    List<Collider2D> monsters = new List<Collider2D>();
    void Start()
    {
        StartCoroutine(delay());
        Destroy(gameObject, 4.1f);
    }

    // Update is called once per frame
    void attack()
    {
        for (int i = 0; i < monsters.Count; i++)
        {
            monster = (Monster)monsters[i].GetComponent(typeof(Monster));
            monster.hp -= 1;
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(1f);
        attack();
        yield return new WaitForSeconds(1f);
        attack();
        yield return new WaitForSeconds(1f);
        attack();
        yield return new WaitForSeconds(1f);
        attack();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Monster" && !monsters.Contains(collision))
        {
            monsters.Add(collision);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Monster") monsters.Remove(collision);
    }
}
