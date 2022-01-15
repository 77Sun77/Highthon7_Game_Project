using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public Slider slider;
    public static string SceneName = "Play_Scene";

    private float time;

    public Text txt;
    int Randomtxt;
    void Start()
    {
        StartCoroutine(LoadAsynSceneCoroutine());
        Randomtxt = Random.Range(1, 4);
    }

     void Update()
    {
        switch(Randomtxt)
        {
            case 1:
                txt.text = "Tip. 문제를 빠르게 풀지 않는다면 몬스터의 수가 증가합니다! ";
                break;
            case 2:
                txt.text = "Tip. 문제를 풀어 친구에게 도움을 주세요!";
                break;
            case 3:
                txt.text = "Tip. 하이톤 사랑해요";
                break;
        }
    }

    IEnumerator LoadAsynSceneCoroutine()
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);

        operation.allowSceneActivation = false;



        while (!operation.isDone)
        {

            time = +Time.time;

            slider.value = time / 10f;

            if (time > 10)
            {
                operation.allowSceneActivation = true;
            }

            yield return null;
        }

    }

}
