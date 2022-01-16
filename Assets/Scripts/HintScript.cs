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
            text.text = "상자를 치워보세요!";
        }
        if (stage == 2)
        {
            text.text = "분필을 한번 먹어보시는게 어떨까요?";
        }
        if (stage == 3)
        {
            text.text = "상자를 이용하면 쉽게 통과할수도?";
        }
       
        if (stage == 5)
        {
            text.text = "셔터의 순서를 확인해보세요!";
        }
        if (stage == 6)
        {
            text.text = "정답이 있는 곳으로 들어간다면?";
        }

    }
}
