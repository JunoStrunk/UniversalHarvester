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
    public bool hasCrop = false;

    
    

    //there is nothing putting this back to true fyi. Will work in with kinnara's script once its done
    //Ideally this bool turns on when a crop is planted
    public bool planted;

    public float timer=0;
    public float cropInterval;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
        
        if (planted == true)
        {
            hasCrop = true;
            //this sets what type of crop is active. Will rework
            if (stage1.name == "First carrot")
            {
                plantname = "carrot";
                cropInterval = 1.5f;
            }
            else if (stage1.name == "First eggplant")
            {
                plantname = "eggplant";
                cropInterval = 2;
            }
            else if (stage1.name == "First potato")
            {
                plantname = "potato";
                cropInterval = 2.5f;
            } else if (stage1.name == "First pepper")
            {
                plantname = "pepper";
                cropInterval = 1;
            } else if (stage1.name == "First beet")
            {
                plantname = "beet";
                cropInterval = 2;
            } else if (stage1.name == "First pumpkin")
            {
                plantname = "pumpkin";
                cropInterval = 4;
            }

            if (timer >= 0 && timer < 15)
            {
                timer += Time.deltaTime;
            }

            if (timer >= 0 && timer < 1*cropInterval && planted == true)
            {
                stage1.SetActive(true);
                stage2.SetActive(false);
                stage3.SetActive(false);

            }
            if (timer >= 1*cropInterval && timer < 2*cropInterval)
            {
                stage1.SetActive(false);
                stage2.SetActive(true);
                stage3.SetActive(false);
            }
            if (timer >= 2*cropInterval && timer < 3*cropInterval)
            {
                stage1.SetActive(false);
                stage2.SetActive(false);
                stage3.SetActive(true);
                done = true;
                

            }
         
            
        }
    }
}
