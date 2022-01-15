using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float angle;
    Vector3 vStart, vEnd;
    void Start()
    {
        vStart = transform.position;
        vEnd = GameObject.Find("Player2").transform.position;
        Vector3 v = vEnd - vStart;
        angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;

        transform.Rotate(new Vector3(0, 0, angle));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * 6 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player2")
        {
            CharacterController player = GameObject.Find("GameManager").GetComponent<CharacterController>();
            player.player2Hp -= 1;
            print("АјАн");
            Destroy(gameObject);
        }
        else if(collision.tag != "Monster") Destroy(gameObject);
    }

}
