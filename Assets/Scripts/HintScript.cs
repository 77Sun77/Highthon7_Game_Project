using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour
{
    public static int stage;
    public Text text;
    public GameObject window;
    private void OnEnable()
    {
        StartCoroutine(activeFalse());
    }
    IEnumerator activeFalse()
    {
        yield return new WaitForSeconds(7f);
        gameObject.SetActive(false);
        window.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(stage == 1)
        {
            text.text = "���ڸ� ġ��������!";
        }
        if (stage == 2)
        {
            text.text = "������ �ѹ� �Ծ�ô°� ����?";
        }
        if (stage == 3)
        {
            text.text = "���ڸ� �̿��ϸ� ���� ����Ҽ���?";
        }
       
        if (stage == 5)
        {
            text.text = "������ ������ Ȯ���غ�����!";
        }
        if (stage == 6)
        {
            text.text = "������ �ִ� ������ ���ٸ�?";
        }

    }
}
