using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected GameObject player2;
    protected float speed;
    public int hp;

    public GameObject hint;

    bool weapon;
    void Start()
    {
        speed = 1;
        weapon = false;
    }

    void Update()
    {
        
    }

    protected void death()
    {
        if (hp <= 0)
        {
            int random = Random.Range(0, 100);
            if (random >= 0 && random < 15)
            {
                GameObject hintGO = Instantiate(hint);
                hintGO.transform.position = transform.position;
            }
            if(random >= 15 && random < 20)
            {
                random = Random.Range(0, 100);
                if (random >= 0 && random < 30) print("우유 드랍");
                else if (random >= 30 && random < 50) print("초코 드랍");
                else if (random >= 50 && random < 60) print("아이스크림 드랍");
                else if (random >= 60 && random < 75) weapon = true;
                else if (random >= 75 && random < 90) print("세이브포인트 드랍");
                else if (random >= 90 && random < 100) print("젤리 드랍");
                if (weapon)
                {
                    random = Random.Range(0, 100);
                    if (random >= 0 && random < 15) print("대걸레 드랍");
                    else if (random >= 15 && random < 50) print("책 드랍");
                    else if (random >= 50 && random < 70) print("분필 드랍");
                    else if (random >= 70 && random < 90) print("나무배트 드랍");
                    else if (random >= 90 && random < 100) print("빗자루와 쓰레받이 드랍");
                }
            }

            


            Destroy(gameObject);
        }
    }
}
