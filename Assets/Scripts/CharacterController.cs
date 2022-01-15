using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject player1, player2;
    void Start()
    {
        
    }

    void Update()
    {
        player1Move();
        player2Move();
    }

    void player1Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        player1.transform.Translate(new Vector2(x, y) * 4 * Time.deltaTime);
    }

    void player2Move()
    {

    }
}
