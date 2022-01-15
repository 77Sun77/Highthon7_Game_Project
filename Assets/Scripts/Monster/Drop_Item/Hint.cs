using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player2")
        {
            GameManager game = GameObject.Find("GameManager").GetComponent<GameManager>();
            game.hintTrue();
            Destroy(gameObject);
        }
    }
}
