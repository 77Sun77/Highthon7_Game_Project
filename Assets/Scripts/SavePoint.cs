using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    Transform tr;
    Vector3 vec;
    
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player2")
        {
            // ���̺� �ڵ�
            vec = tr.transform.localPosition;
            Destroy(gameObject);
        }
    }
}
