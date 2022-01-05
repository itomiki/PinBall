using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour{

    //Ball_ga_mieru-kanousei_no_aru_z-jiku_no_minimum
    private float visiblePosZ = -6.5f;

    //GameOver_wo_hyouji_suru_text
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start(){
        //Scene-tyuu_no_GameOverText-object_wo_syutoku
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update(){
        //Ball_ga_gamen-gai_ni_deta-baai
        if(this.transform.position.z < this.visiblePosZ){
            //GameoverText_ni_Game-Over_wo_hyouji
            this.gameoverText.GetComponent<Text>().text = "Game Over";
		}
    }
}
