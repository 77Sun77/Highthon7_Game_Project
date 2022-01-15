using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shutter : MonoBehaviour
{
    public GameObject isShutter;
    SpriteRenderer sp;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isShutter.SetActive(false);
            sp.color = new Color(142 / 255f, 142 / 255f, 142 / 255f, 255 / 255f);
        }
    }
}
