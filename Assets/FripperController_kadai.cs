using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController_kadai : MonoBehaviour{

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

        //A-Key_wo_osita_tokini_Left-Fripper_wo_ugokasu
        if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag"){
            SetAngle(this.flickAngle);
		}

        //D-Key_wo_osita_tokini_Right-Fripper_wo_ugokasu
        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag"){
            SetAngle(this.flickAngle);
		}

        //S-Key_or_DownArrow-Key_wo_osita_tokini_Right-Fripper_and_Left-Fripper_wo_ugokasu
        if (Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag"){
            SetAngle(this.flickAngle);
		}

        //Key_ga_hanasareta_toki_Fripper_wo_motoni-modosu
        if (Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag"){
            SetAngle(this.defaultAngle);
		}

        if (Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag"){
            SetAngle(this.defaultAngle);
		}

        if (Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag"){
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
