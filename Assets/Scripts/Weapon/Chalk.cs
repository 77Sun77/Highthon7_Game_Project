using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chalk : MonoBehaviour
{
    float angle;
    public Vector3 vStart, vEnd;
    Animator anim;

    public GameObject attack;
    void Start()
    {
        Destroy(gameObject, 5f);

        vStart = transform.position;
        Vector3 v = vEnd - vStart;
        angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;

        transform.Rotate(new Vector3(0, 0, angle));

        anim = GetComponent<Animator>();
        int random = Random.Range(0, 3);
        anim.SetInteger("int", random);
    }

    void Update()
    {
        transform.Translate(Vector2.right * 8 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            Monster monster = (Monster) collision.GetComponent(typeof(Monster));
            monster.hp -= 1;
            GameObject attackGO = Instantiate(attack);
            attackGO.transform.position = transform.position;
            attackGO.transform.Rotate(new Vector3(0, 0, angle - 90));
            Destroy(attackGO, 5f);
            Destroy(gameObject);
        }
    }
    
}
