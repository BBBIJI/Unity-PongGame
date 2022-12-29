using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRight : MonoBehaviour
{
    public Text Score_R;
    int ScoreNum = 0;

    void Start()
    {
        Score_R.text = ScoreNum.ToString();
    }
    void update(){
    }

    void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == "Ball"){
            ScoreNum++;
            Score_R.text = ScoreNum.ToString();
        }
    }
}