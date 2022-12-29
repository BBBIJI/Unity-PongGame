using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_Movement : MonoBehaviour
{
    float speed_x = 3f;
    float speed_y = 3f;

    void Start(){
        PauseGame();
    }

    void Update(){
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)||Input.GetKey("up")||Input.GetKey("down")){
                    ResumeGame();
        }
        transform.Translate(speed_x*Time.deltaTime,speed_y*Time.deltaTime,0);   

        if(speed_x>0){
            speed_x += 0.01f;
        }
        if(speed_y>0){
            speed_y += 0.01f;
        }
        if(speed_x<0){
            speed_x -= 0.01f;
        }
        if(speed_y<0){
            speed_y -= 0.01f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == "Up_Wall")
        {
            speed_y = -speed_y;
        }
        if (collision.gameObject.tag == "Low_Wall")
        {
            speed_y = -speed_y;
        }
        if (collision.gameObject.tag == "Right_Wall")
        {
            transform.position = new Vector3(0,0,0);
            speed_x=3f;
            speed_y=3f;
            PauseGame();
        }
        if (collision.gameObject.tag == "Left_Wall")
        {
            transform.position = new Vector3(0,0,0);
            speed_x=3f;
            speed_y=3f;
            PauseGame();
        }
        if (collision.gameObject.tag == "Player_Left")
        {
            speed_x = -speed_x;
        }
        if (collision.gameObject.tag == "Player_Right")
        {
            speed_x = -speed_x;
        }

    }

    void PauseGame ()
    {
        Time.timeScale = 0;
    }
    void ResumeGame ()
    {
        Time.timeScale = 1;
    }
}
