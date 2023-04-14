using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantDelay : MonoBehaviour
{
    //PUT THIS ON A MANAGER

    //controls growing
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;


    public string plantname;
    public bool done=false;
    public static PlantDelay instance;
    

    //there is nothing putting this back to true fyi. Will work in with kinnara's script once its done
    //Ideally this bool turns on when a crop is planted
    public bool planted=true;

    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //this sets what type of crop is active. Will rework
        if (planted == true)
        {
            if (stage1.gameObject.name == "SM_Prop_Carrot_01_S")
            {
                plantname = "carrot";
            }
            else if (stage1.gameObject.name == "SM_Prop_Eggplant_01_S")
            {
                plantname = "eggplant";
            }
            else if (stage1.gameObject.name == "SM_Prop_Potato_01_S")
            {
                plantname = "potato";
            }

            if (timer >= 0 && timer < 15)
            {
                timer += Time.deltaTime;
            }

            if (timer >= 0 && timer < 5 && planted == true)
            {
                stage1.SetActive(true);
                stage2.SetActive(false);
                stage3.SetActive(false);

            }
            if (timer >= 5 && timer < 10)
            {
                stage1.SetActive(false);
                stage2.SetActive(true);
                stage3.SetActive(false);
            }
            if (timer >= 10 && timer < 15)
            {
                stage1.SetActive(false);
                stage2.SetActive(false);
                stage3.SetActive(true);
                done = true;

            }
            if (CropTracker.instance.isHarvested == true)
            {
                
                Reset();
                //TURN THIS BACK ON IN KINNARA PLANT SCRIPT 
              //  CropTracker.instance.isHarvested = false;
            }
        }
    }

     void Reset()
    {
         Debug.Log("Reset");
         timer = 0;
         stage1.SetActive(false);
         stage2.SetActive(false);
         stage3.SetActive(false);
         done = false;
        planted = false;
       
    }
}
