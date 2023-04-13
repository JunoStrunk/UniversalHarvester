using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantDelay : MonoBehaviour
{
    //PUT THIS ON A MANAGER
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public string plantname;
    public bool done=false;
    public static PlantDelay instance;
    public GameObject Manager;

    public bool planted=true;

    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        Manager = this.gameObject;  
    }
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
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

            if (timer >= 0 && timer < 5)
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
                CropTracker.instance.isHarvested = false;
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
       
    }
}
