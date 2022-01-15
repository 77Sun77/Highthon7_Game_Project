using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroomstickSkill : MonoBehaviour
{
    bool isAttack;

    BoxCollider2D col;
    void Start()
    {
        StartCoroutine(attack());
        Destroy(gameObject, 1.1f);
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator attack()
    {
        yield return new WaitForSeconds(0.3f);
        isAttack = true;
        col.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Monster" && isAttack)
        {
            Monster monster = (Monster)collision.GetComponent(typeof(Monster));
            monster.hp -= 3;
        }
    }
}
