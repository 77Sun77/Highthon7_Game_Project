using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourPoint : MonoBehaviour
{
    public static int truePoint = 0;
    public static bool isPoint = false;
    public GameObject go;

    public SpriteRenderer bt1;
    public SpriteRenderer bt2;
    public SpriteRenderer bt3;
    public SpriteRenderer bt4;

    public GameObject Shutter1;
    public GameObject Shutter2;
    public GameObject Shutter3;
    public GameObject Shutter4;

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isPoint == true)
        {
            if (collision.tag == "down" && truePoint == 0)
            {
                bt1.color = new Color(142 / 255f, 142 / 255f, 142 / 255f, 255 / 255f);
                truePoint++;
                Shutter1.SetActive(false);
            }
            else if (collision.tag == "left" && truePoint == 1)
            {
                bt2.color = new Color(142 / 255f, 142 / 255f, 142 / 255f, 255 / 255f);
                truePoint++;
                Shutter2.SetActive(false);
            }
            else if (collision.tag == "right" && truePoint == 2)
            {
                bt3.color = new Color(142 / 255f, 142 / 255f, 142 / 255f, 255 / 255f);
                truePoint++;
                Shutter3.SetActive(false);
            }
            else if (collision.tag == "up" && truePoint == 3)
            {
                bt4.color = new Color(142 / 255f, 142 / 255f, 142 / 255f, 255 / 255f);
                truePoint++;
                Shutter4.SetActive(false);
                go.SetActive(false);
                isPoint = false;
            }
            else
            {
                bt1.color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                bt2.color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                bt3.color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                bt4.color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                Shutter4.SetActive(true);
                Shutter4.SetActive(true);
                Shutter4.SetActive(true);
                Shutter4.SetActive(true);
                truePoint = 0;
                ProblemKinds.FailStac++;
                Debug.Log("½ÇÆÐ");
            }
        }

    }
}
