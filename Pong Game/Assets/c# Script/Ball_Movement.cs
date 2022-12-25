using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    float speed_x = 0.1f;
    float speed_y = 0.1f;
    void Update()
    {
        transform.Translate(speed_x,speed_y,0);   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Up_Wall")
        {
            speed_y = -speed_y;
        }
        if (collision.gameObject.tag == "Low_Wall")
        {
            speed_y = -speed_y;
            Debug.Log("kontol");
        }
        if (collision.gameObject.tag == "Right_Wall")
        {
            speed_x = -speed_x;
        }
        if (collision.gameObject.tag == "Left_Wall")
        {
            speed_x = -speed_x;
        }





    }
}
