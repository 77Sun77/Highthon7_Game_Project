using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    int randomNum;
    int randomNum2;
    int sum;
    int wrongSum;
    int randomSum;
    int randomTransform;
    string randomSee1;
    string randomSee2;

    public TextMesh Mathtxt;
    public TextMesh See1;
    public TextMesh See2;
    public BoxCollider2D Answer1;
    public BoxCollider2D Answer2;

    bool istrue;

    private void Start()
    {
        MathQ();
    }
    void MathQ()
    {
        randomNum = Random.Range(1, 100);
        randomNum2 = Random.Range(1, 100);
        randomSum = Random.Range(1, 3);
        randomTransform = Random.Range(1, 3);

        randomSee1 = randomNum.ToString();
        randomSee2 = randomNum2.ToString();

        Mathtxt.text = randomSee1 + "+" + randomSee2;

        sum = randomNum + randomNum2;
        if (randomSum == 1) wrongSum = sum - 1;
        if (randomSum == 2) wrongSum = sum + 1;

        randomSee1 = sum.ToString();
        randomSee2 = wrongSum.ToString();

        if (randomSum == 1) { 
            See1.text = randomSee1;
            See2.text = randomSee2;
            istrue = true;
        }
        if (randomSum == 2)
        {
            See1.text = randomSee2;
            See2.text = randomSee1;
            istrue = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "MathAnswer")
        {
            if (istrue == true) Debug.Log("성공");
            else Debug.Log("실패");
        }

        else if (collision.tag == "MathAnswer2")
        {
            if (istrue == false) Debug.Log("성공");
            else Debug.Log("실패");
        }
    }
}