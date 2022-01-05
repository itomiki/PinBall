using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour{

    //Minimum-size
    private float minimum = 1.0f;

    //Kakudai-syukusyou-speed
    private float magSpeed = 10.0f;

    //Kakudai-ritu
    private float magnification = 0.07f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //Kumo_wo_kakudai-syukusyou
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
    }
}
