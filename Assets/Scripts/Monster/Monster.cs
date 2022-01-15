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

    GameObject item;
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
        ItemDrop item = GameObject.Find("ItemDrop").GetComponent<ItemDrop>();
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
                if (random >= 0 && random < 30) this.item = item.spawnMilk();
                else if (random >= 30 && random < 50) this.item = item.spawnChoco();
                else if (random >= 50 && random < 60) this.item = item.spawnIceCream();
                else if (random >= 60 && random < 75) weapon = true;
                else if (random >= 75 && random < 90) this.item = item.spawnSavePoint();
                else if (random >= 90 && random < 100) this.item = item.spawnJelly();
                if (weapon)
                {
                    random = Random.Range(0, 100);
                    if (random >= 0 && random < 15) this.item = item.spawnMop();
                    else if (random >= 15 && random < 50) this.item = item.spawnBook();
                    else if (random >= 50 && random < 70) this.item = item.spawnChalk();
                    else if (random >= 70 && random < 90) this.item = item.spawnBase();
                    else if (random >= 90 && random < 100) this.item = item.spawnBroomstick();
                }
                this.item.transform.position = transform.position;
            }



            CharacterController.skillPoint += 10;
            Destroy(gameObject);
        }
    }
}
