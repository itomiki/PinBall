using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour{

    //Score
    private int Score = 0;

    //Kasan_suru_score
	private int AddScore;

    //Score_wo_hyouji_suru_text
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start(){

        //Tag_ni_yotte_tokuten_wo_settei
        if(tag == "SmallStarTag"){
            AddScore = 40;

		}else if(tag == "LargeStarTag"){
            AddScore = 20;

		}else if(tag == "SmallCloudTag"){
            AddScore = 30;

		}else if(tag == "LargeCloudTag"){
            AddScore = 10;

		}

        //Scene-tyuu_no_ScoreText-object_wo_syutoku
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update(){

    }

    //Syoutotu-ji_ni_yobareru_kansuu
    void OnCollisionEnter(Collision other){
        //Score_ni_kasansuru
        Score += AddScore;
        //ScoreText_ni_Score_wo_hyouji
        this.scoreText.GetComponent<Text>().text = "SCORE\n" + Score;
    }
}
