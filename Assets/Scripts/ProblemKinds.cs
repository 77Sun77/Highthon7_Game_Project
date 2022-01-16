using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProblemKinds : MonoBehaviour
{
    public TextMesh Chilpantxt;
    [Header("Problems")]
    public TextMesh Problem1;
    public TextMesh Problem2;
    public TextMesh Problem3;
    public TextMesh Problem4;

    [Header("Locker")]
    public SpriteRenderer Locker1;
    public SpriteRenderer Locker2;
    public SpriteRenderer Locker3;
    public SpriteRenderer Locker4;
    public Sprite changeSprite;


    private bool isAnswer1 = false;
    private bool isAnswer2 = false;
    private bool isAnswer3 = false;
    private bool isAnswer4 = false;

    private bool isNonsense = false;
    private bool isCommonsense = false;

    int RandomProblem;

    bool istrue = true;

    public static int FailStac = 0;
    public static int stack;
    void Start()
    {
        isNonsense = true;
        Question();
        stack = 0;
    }

    void Update()
    {
    }

    void Question()
    {
        stack++;
        if (isNonsense == true)
        {
            RandomProblem = Random.Range(1, 4);
            isNonsense = false;
        }

        else if (isCommonsense == true)
        {
            RandomProblem = Random.Range(4, 7);
            isCommonsense = false;
        }
    
        switch (RandomProblem)
            {
                case 1:
                    Chilpantxt.text = "북한 사람들은 ‘라면’을 뭐라고 할까?";
                    Problem1.text = "매운 국수";
                    Problem2.text = "소금 국수";
                    Problem3.text = "꼬부랑 국수";
                    Problem4.text = "맛난 국수";
                    isAnswer3 = true;
                    break;
                case 2:
                    Chilpantxt.text = "겨울잠을 자는 동물이 아닌 것은?";
                    Problem1.text = "토끼";
                    Problem2.text = "곰";
                    Problem3.text = "뱀";
                    Problem4.text = "자라";
                    isAnswer1 = true;
                    break;
                case 3:
                    Chilpantxt.text = "화성과 태양 사이에 존재하지 않는 행성은?";
                    Problem1.text = "지구";
                    Problem2.text = "수성";
                    Problem3.text = "금성";
                    Problem4.text = "목성";
                    isAnswer4 = true;
                    break;
                case 4:
                   Chilpantxt.text = "타이타닉의 구명 보트에는 몇 명이 탈수 있을까?";
                    Problem1.text = "18명";
                    Problem2.text = "2명";
                    Problem3.text = "5명";
                    Problem4.text = "9명";
                    isAnswer4 = true;
                    break;
                case 5:
                    Chilpantxt.text = "아침에는 4발 점심에는 2발 저녁에는 3발인것은? ";
                   Problem1.text = "스핑크스";
                   Problem2.text = "사람";
                   Problem3.text = "강아지";
                   Problem4.text = "고양이";
                   isAnswer2 = true;
                break;
                case 6:
                   Chilpantxt.text = "모든 사람들을 일어서게 하는 숫자는?";
                   Problem1.text = "5";
                   Problem2.text = "7";
                   Problem3.text = "3";
                   Problem4.text = "21";
                   isAnswer1 = true;
                break;
            }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && istrue == true)
        {
            if (collision.tag == "Answer1" && isAnswer1 == true)
            {
                Locker1.sprite = changeSprite;
                Debug.Log("정답");
                isCommonsense = true;
                istrue = false;
                StartCoroutine(StopCount());
            }

            else if (collision.tag == "Answer2" && isAnswer2 == true)
            {
                Locker2.sprite = changeSprite;
                Debug.Log("정답");
                isCommonsense = true;
                istrue = false;
                StartCoroutine(StopCount());
            }

            else if (collision.tag == "Answer3" && isAnswer3 == true)
            {
                Locker3.sprite = changeSprite;
                Debug.Log("정답");
                isCommonsense = true;
                istrue = false;
                StartCoroutine(StopCount());
            }

            else if (collision.tag == "Answer4" && isAnswer4 == true)
            {
                Locker4.sprite = changeSprite;
                Debug.Log("정답");
                isCommonsense = true;
                istrue = false;
                StartCoroutine(StopCount());
            }
            else
            {
                isAnswer1 = false;
                isAnswer2 = false;
                isAnswer3 = false;
                isAnswer4 = false;
                FailStac++;
            }
        }
    }

    IEnumerator StopCount()
    {
        yield return new WaitForSeconds(3f);
        isAnswer1 = false;
        isAnswer2 = false;
        isAnswer3 = false;
        isAnswer4 = false;
        istrue = true;
    }
}
