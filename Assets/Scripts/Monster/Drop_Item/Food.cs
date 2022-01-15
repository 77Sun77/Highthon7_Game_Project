using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public string name;
    int heal;
    void Start()
    {
        if (name == "우유") heal = 3;
        if (name == "초코") heal = 5;
        if (name == "아이스크림") heal = 100;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player2")
        {
            CharacterController player2 = GameObject.Find("GameManager").GetComponent<CharacterController>();
            if (name != "젤리")
            {
                player2.player2Hp += heal;
                if (player2.player2Hp > player2.maxHp) player2.player2Hp = player2.maxHp;
                Destroy(gameObject);
            }
            else
            {
                player2.maxHp += 5;
                Destroy(gameObject);

            }
        }
    }
}
