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

    
    

    //there is nothing putting this back to true fyi. Will work in with kinnara's script once its done
    //Ideally this bool turns on when a crop is planted
    public bool planted=true;

    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
        
        if (planted == true)
        {

            //this sets what type of crop is active. Will rework
            if (stage1.name == "First carrot")
            {
                plantname = "carrot";
            }
            else if (stage1.name == "First eggplant")
            {
                plantname = "eggplant";
            }
            else if (stage1.name == "First potato")
            {
                plantname = "potato";
            } else if (stage1.name == "First pepper")
            {
                plantname = "pepper";
            }

            if (timer >= 0 && timer < 15)
            {
                timer += Time.deltaTime;
            }

            if (timer >= 0 && timer < 3 && planted == true)
            {
                stage1.SetActive(true);
                stage2.SetActive(false);
                stage3.SetActive(false);

            }
            if (timer >= 3 && timer < 6)
            {
                stage1.SetActive(false);
                stage2.SetActive(true);
                stage3.SetActive(false);
            }
            if (timer >= 6 && timer < 9)
            {
                stage1.SetActive(false);
                stage2.SetActive(false);
                stage3.SetActive(true);
                done = true;

            }
            if (CropTracker.instance.isHarvested == true)
            {
               // Reset();
            }
        }
    }

     void Reset()
    {
           

         Debug.Log("Reset");
      /*   timer = 0;
         stage1.SetActive(false);
         stage2.SetActive(false);
         stage3.SetActive(false);
         done = false;
        planted = false; */
       
    }
}
