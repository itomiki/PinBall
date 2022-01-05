using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour{

    //HingeJoint-component_wo_ireru
    private HingeJoint myHingeJoint;

    //Syoki_no_katamuki
    private float defaultAngle = 20;

    //Hajiita-toki_no_katamuki
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start(){

        //HingeJoint-component_syutoku
        this.myHingeJoint = GetComponent<HingeJoint>();

        //Fripper_no_katamuki_wo_settei
        SetAngle(this.defaultAngle);
        
    }

    // Update is called once per frame
    void Update(){

        //Left-Arrow-Key_wo_osita_tokini_Left-Fripper_wo_ugokasu
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag"){
            SetAngle(this.flickAngle);
		}

        //Right-Arrow-Key_wo_osita_tokini_Right-Fripper_wo_ugokasu
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag"){
            SetAngle(this.flickAngle);
		}

        //Arrow-Key_ga_hanasareta_toki_Fripper_wo_motoni-modosu
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag"){
            SetAngle(this.defaultAngle);
		}

        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag"){
            SetAngle(this.defaultAngle);
		}
    }

    //Fripper_no_katamuki_wo_settei
    public void SetAngle(float angle){

        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

	}
}
