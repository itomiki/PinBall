using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour{

    //Material_wo_ireru
    Material myMaterial;

    //Emission_no_minimum
    private float minEmission = 0.2f;
    //Emission_no_kyoud
    private float magEmission = 2.0f;
    //Kakudo
    private int degree = 0;
    //Hakkou-sokudo
    private int speed = 5;
    //target_no_default_no_color
    Color defaultColor = Color.white;

    // Start is called before the first frame update
    void Start(){

        //Tag_ni_yotte_hikaraseru-iro_wo_kaeru
        if(tag == "SmallStarTag"){
            this.defaultColor = Color.white;

		}else if(tag == "LargeStarTag"){
            this.defaultColor = Color.yellow;

		}else if(tag == "SmallCloudTag" || tag == "LargeCloudTag"){
            this.defaultColor = Color.cyan;
		}

        //Object_ni_attach-siteiru_Material_wo_syutoku
        this.myMaterial = GetComponent<Renderer>().material;

        //Object_no_saisyo_no_iro_wo_settei
        myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);
    }

    // Update is called once per frame
    void Update(){

        if(this.degree >= 0){
            //Hikaraseru-kyoudo_wo_keisan
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin (this.degree * Mathf.Deg2Rad) * this.magEmission);

            //Emission_ni_iro_wo_settei
            myMaterial.SetColor("_EmissionColor", emissionColor);

            //Genzai_no_kakudo_wo_tiisaku_suru
            this.degree -= this.speed;
		}
    }

    //Syoutotu-ji_ni_yobareru_kansuu
    void OnCollisionEnter(Collision other){
        //Kakudo_wo_180_ni_settei
        this.degree = 180; 
    }
}
