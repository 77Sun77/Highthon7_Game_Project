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
                txt.text = "Tip. ������ ������ Ǯ�� �ʴ´ٸ� ������ ���� �����մϴ�! ";
                break;
            case 2:
                txt.text = "Tip. ������ Ǯ�� ģ������ ������ �ּ���!";
                break;
            case 3:
                txt.text = "Tip. ������ ����ؿ�";
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
