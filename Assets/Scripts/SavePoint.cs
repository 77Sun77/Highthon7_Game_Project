using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
<<<<<<< HEAD
    Transform tr;
    int Num;

    private void Start()
    {
        tr = GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Num++;
        }
    }


=======
    
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
            // 세이브 코드

            Destroy(gameObject);
        }
    }
>>>>>>> 59517f2372843446ab46ec090b0fcee361792ee6
}
