using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour{

    //Kaiten-sokudo
    private float rotSpeed = 0.5f;

    // Start is called before the first frame update
    void Start(){
        //Kaiten_wo_kaisi_suru_kakudo
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update(){
        //Kaiten
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
