using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CropTracker : MonoBehaviour
{
   
    public int carrottot;
    public int potatotot;
    public int eggplanttot;
    public int pepperstot;
    public int pumpkintot;
    public int beetstot;
    public int numToPrint;
    public float earnedMoney;
    public string totint;
    public string numToPrintint;
    
    //These  control which plot is being interacted with and the plant type
    public string plantType;
    public string plotLocation;
    public string lookUp;
    public GameObject croptoHarvest;

    public static CropTracker instance;

    public bool isHarvested=false;
    public bool inRange = false;
    
    //this stuff is important
    public string manager;
    public GameObject managerSpecific;

    //message that appears when you harvest
    public GameObject signBoardandMessage;
    public TextMeshProUGUI Message;
    

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
        //finds the growthmanager for the plot the player is in
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
                        signBoardandMessage.SetActive(true);
                        Plant();
                        Message.text = "You got " + numToPrintint +" " + plantType + "s. You have " + totint +" " + plantType + "s.";


                    }
                }

            }
               //reseter
            if(isHarvested==true && managerSpecific.GetComponent<PlantDelay>().done== true)
            {
                managerSpecific.GetComponent<PlantDelay>().timer = 0;
                managerSpecific.GetComponent<PlantDelay>().done = false;
                isHarvested = false;
                managerSpecific.GetComponent<PlantDelay>().planted = false;
            }
        }

    }
    
   void Plant()
    {
        if (plantType == "carrot")
        {
            carrottot += 12;
            numToPrint = 12;
            totint = carrottot.ToString("0");
            
        } else if (plantType == "eggplant")
        {
            eggplanttot += 24;
            numToPrint = 24;
            totint = eggplanttot.ToString("0");
        } else if (plantType == "potato")
        {
            potatotot += 16;
            numToPrint = 16;
            totint = potatotot.ToString("0");
        } else if (plantType == "pepper")
        {
            pepperstot += 84;
            numToPrint = 84;
            totint = pepperstot.ToString("0");
        } else if (plantType == "beet")
        {
            beetstot += 20;
            numToPrint = 20;
            totint = beetstot.ToString("0");
        } else if (plantType == "pumpkin")
        {
            pumpkintot += 4;
            numToPrint = 4;
            totint = pumpkintot.ToString("0");
        }
        numToPrintint = numToPrint.ToString("0");
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
