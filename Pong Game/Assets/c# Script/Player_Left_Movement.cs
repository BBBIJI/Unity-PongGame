using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Left_Movement : MonoBehaviour
{
    public float speed = 7;
    // Update is called once per frame
    void Update()
    {
        float move = speed;
        
        move *= Time.deltaTime;
        
        if(Input.GetKey(KeyCode.W)){
        transform.Translate(0,move,0);
        }
        if(Input.GetKey(KeyCode.S)){
        transform.Translate(0,-move,0);
        }

    }

}
