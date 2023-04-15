using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropTracker : MonoBehaviour
{
    public int carrot;
    public int potato;
    public int eggplant;
    public int peppers;
    public int cucumbers;
    public int beets;
    public float earnedMoney;
    
    //These  control which plot is being interacted with and the plant type
    public string plantType;
    public string plotLocation;
    public string lookUp;
    public GameObject croptoHarvest;

    public static CropTracker instance;

    public bool isHarvested=false;
    public bool inRange = false;
    
    public string manager;
  
    public GameObject managerSpecific;
    

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //finds the growthmanager
        if (inRange == true)
        {
            manager =  GameObject.Find(plotLocation +"GrowthManager").name;
            managerSpecific = GameObject.Find(manager);

        }
        //using said growthmanager, find the active plant
        if (managerSpecific != null)
        {
            plantType = managerSpecific.GetComponent<PlantDelay>().plantname;
            if (managerSpecific.GetComponent<PlantDelay>().done == true && inRange == true)
            {
                lookUp = plotLocation + plantType;
                croptoHarvest = GameObject.Find(lookUp);
                if (Input.GetKeyDown(KeyCode.E))
                {

                    if (croptoHarvest != null)
                    {
                        Debug.Log(plotLocation + plantType);
                        croptoHarvest.SetActive(false);
                        isHarvested = true;
                    }
                }

            }
       
            if(isHarvested==true && managerSpecific.GetComponent<PlantDelay>().done== true)
            {
                managerSpecific.GetComponent<PlantDelay>().timer = 0;
                managerSpecific.GetComponent<PlantDelay>().done = false;
                isHarvested = false;
                managerSpecific.GetComponent<PlantDelay>().planted = false;
            }
        }

    }
    
  

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "B1")
        {
            plotLocation = "B1 ";
            inRange = true;
        } else if (other.gameObject.tag == "B2")
        {
            plotLocation = "B2 ";
            inRange = true;
        } else if (other.gameObject.tag == "B3")
        {
            plotLocation = "B3 ";
            inRange = true;
        } else if (other.gameObject.tag == "B4")
        {
            plotLocation = "B4 ";
            inRange = true;
        } else if (other.gameObject.tag == "A1")
        {
            plotLocation = "A1 ";
            inRange = true;
        } else if (other.gameObject.tag == "A2")
        {
            plotLocation = "A2 ";
            inRange = true;
        } else if (other.gameObject.tag == "A3")
        {
            plotLocation = "A3 ";
            inRange = true;
        } else if (other.gameObject.tag == "A4")
        {
            plotLocation = "A4 ";
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            plotLocation = "";
            croptoHarvest = null;
            inRange = false;
        }
    }
}
