using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player1, player2;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player1.transform.position.x <= 7 && player2.transform.position.x <= 7) Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(0, 0, -10), 3 * Time.deltaTime);
        else if(player1.transform.position.x > 7 && player2.transform.position.x > 7) Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(14, 0, -10), 3 * Time.deltaTime);
    }
}
