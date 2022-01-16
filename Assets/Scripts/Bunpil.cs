using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunpil : MonoBehaviour
{
    public GameObject Tables;

    public static bool two;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FourPoint.isPoint = true;
            two = true;
            Destroy(gameObject);
            Tables.SetActive(false);
        }
    }
}
