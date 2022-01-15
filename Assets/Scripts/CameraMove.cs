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






        if (player1.transform.position.x > 227 && player2.transform.position.x > 227)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(235, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 218 && player2.transform.position.x > 218)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(220, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 203 && player2.transform.position.x > 203)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(210, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 189 && player2.transform.position.x > 189)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(197, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 174 && player2.transform.position.x > 174)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(181, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 161 && player2.transform.position.x > 161)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(166, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 146 && player2.transform.position.x > 146)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(154, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 130 && player2.transform.position.x > 130)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(138, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 115 && player2.transform.position.x > 115)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(123, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 100 && player2.transform.position.x > 100)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(107, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 84 && player2.transform.position.x > 84)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(92, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 68 && player2.transform.position.x > 68)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(76, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 52 && player2.transform.position.x > 52)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(60, 0, -10), 3 * Time.deltaTime);
        }
        else if (player1.transform.position.x > 36 && player2.transform.position.x > 36) Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(44, 0, -10), 3 * Time.deltaTime);
        else if (player1.transform.position.x > 14 && player2.transform.position.x > 14) Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(28, 0, -10), 3 * Time.deltaTime);
        else if(player1.transform.position.x > 7 && player2.transform.position.x > 7) Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(14, 0, -10), 3 * Time.deltaTime);
    }
}
