using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected GameObject player2;
    protected float speed;
    public int hp;

    public GameObject hint;
    void Start()
    {
        speed = 1;
       
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


            Destroy(gameObject);
        }
    }
}
