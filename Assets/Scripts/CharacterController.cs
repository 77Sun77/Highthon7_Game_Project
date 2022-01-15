using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject player1, player2;
    public Rigidbody2D rigid1, rigid2;
    public float maxSpeed;
    Vector2 mousePos;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        }
    }

    private void FixedUpdate()
    {
        player1Move();
        player2Move();
    }

    void player1Move()
    {
        float h = Input.GetAxis("Horizontal");
        float w = Input.GetAxis("Vertical");
        rigid1.velocity = new Vector2(h, w) * maxSpeed;
    }

    void player2Move()
    {
        player2.transform.position = Vector3.Lerp(player2.transform.position, mousePos, (maxSpeed-2) * Time.deltaTime);
    }
}
