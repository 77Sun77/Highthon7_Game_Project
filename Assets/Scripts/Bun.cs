using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bun : MonoBehaviour
{
    public GameObject Tables;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FourPoint.isPoint = true;
            Destroy(gameObject);
            Tables.SetActive(false);
        }
    }
}
