using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Right_Movement : MonoBehaviour
{
	float speed = 5;
    // Update is called once per frame
    void Update()
    {
        float move = speed;
        
        move *= Time.deltaTime;
        
        if(Input.GetKey("up")){
        transform.Translate(0,move,0);
        }
        if(Input.GetKey("down")){
        transform.Translate(0,-move,0);
        }

    }
}