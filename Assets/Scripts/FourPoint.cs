using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourPoint : MonoBehaviour
{
    private int truePoint = 0;
    public static bool isPoint = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isPoint == true)
        {
            if (collision.tag == "down" && truePoint == 0) truePoint++;
            else if (collision.tag == "left" && truePoint == 1) truePoint++;
            else if (collision.tag == "right" && truePoint == 2) truePoint++;
            else if (collision.tag == "up" && truePoint == 3)
            {
                truePoint++;
                Debug.Log("Ŭ����");
            }
            else
            {
                ProblemKinds.FailStac++;
                Debug.Log("����");
                truePoint = 0;
            }
        }

    }
}
