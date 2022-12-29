using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLeft : MonoBehaviour
{
    public Text Score_L;
    int ScoreNum = 0;

    void Start()
    {
        Score_L.text = ScoreNum.ToString();
    }
    void update(){
    }

    void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == "Ball"){
            ScoreNum++;
            Score_L.text = ScoreNum.ToString();
        }
    }
}
