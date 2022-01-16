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
                    Chilpantxt.text = "���� ������� ����顯�� ����� �ұ�?";
                    Problem1.text = "�ſ� ����";
                    Problem2.text = "�ұ� ����";
                    Problem3.text = "���ζ� ����";
                    Problem4.text = "���� ����";
                    isAnswer3 = true;
                    break;
                case 2:
                    Chilpantxt.text = "�ܿ����� �ڴ� ������ �ƴ� ����?";
                    Problem1.text = "�䳢";
                    Problem2.text = "��";
                    Problem3.text = "��";
                    Problem4.text = "�ڶ�";
                    isAnswer1 = true;
                    break;
                case 3:
                    Chilpantxt.text = "ȭ���� �¾� ���̿� �������� �ʴ� �༺��?";
                    Problem1.text = "����";
                    Problem2.text = "����";
                    Problem3.text = "�ݼ�";
                    Problem4.text = "��";
                    isAnswer4 = true;
                    break;
                case 4:
                   Chilpantxt.text = "Ÿ��Ÿ���� ���� ��Ʈ���� �� ���� Ż�� ������?";
                    Problem1.text = "18��";
                    Problem2.text = "2��";
                    Problem3.text = "5��";
                    Problem4.text = "9��";
                    isAnswer4 = true;
                    break;
                case 5:
                    Chilpantxt.text = "��ħ���� 4�� ���ɿ��� 2�� ���ῡ�� 3���ΰ���? ";
                   Problem1.text = "����ũ��";
                   Problem2.text = "���";
                   Problem3.text = "������";
                   Problem4.text = "�����";
                   isAnswer2 = true;
                break;
                case 6:
                   Chilpantxt.text = "��� ������� �Ͼ�� �ϴ� ���ڴ�?";
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
                Debug.Log("����");
                isCommonsense = true;
                istrue = false;
                StartCoroutine(StopCount());
            }

            else if (collision.tag == "Answer2" && isAnswer2 == true)
            {
                Locker2.sprite = changeSprite;
                Debug.Log("����");
                isCommonsense = true;
                istrue = false;
                StartCoroutine(StopCount());
            }

            else if (collision.tag == "Answer3" && isAnswer3 == true)
            {
                Locker3.sprite = changeSprite;
                Debug.Log("����");
                isCommonsense = true;
                istrue = false;
                StartCoroutine(StopCount());
            }

            else if (collision.tag == "Answer4" && isAnswer4 == true)
            {
                Locker4.sprite = changeSprite;
                Debug.Log("����");
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
