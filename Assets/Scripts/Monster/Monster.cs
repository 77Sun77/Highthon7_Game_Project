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
                if (random >= 0 && random < 30) print("���� ���");
                else if (random >= 30 && random < 50) print("���� ���");
                else if (random >= 50 && random < 60) print("���̽�ũ�� ���");
                else if (random >= 60 && random < 75) weapon = true;
                else if (random >= 75 && random < 90) print("���̺�����Ʈ ���");
                else if (random >= 90 && random < 100) print("���� ���");
                if (weapon)
                {
                    random = Random.Range(0, 100);
                    if (random >= 0 && random < 15) print("��ɷ� ���");
                    else if (random >= 15 && random < 50) print("å ���");
                    else if (random >= 50 && random < 70) print("���� ���");
                    else if (random >= 70 && random < 90) print("������Ʈ ���");
                    else if (random >= 90 && random < 100) print("���ڷ�� �������� ���");
                }
            }

            


            Destroy(gameObject);
        }
    }
}
