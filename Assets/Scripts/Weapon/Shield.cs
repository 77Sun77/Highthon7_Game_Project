using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public int hp;
    CharacterController c1;
    void Start()
    {
        Destroy(gameObject, 1f);
        c1 = GameObject.Find("GameManager").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        c1.player2Hp = hp;
    }
}
