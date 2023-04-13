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
    
    //These four control which plot is being interacted with and the plant type
    public string plantType;
    public string plotLocation;
    public string lookUp;
    public GameObject croptoHarvest;

    public static CropTracker instance;

    public bool isHarvested=false;

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
        plantType = PlantDelay.instance.plantname;
        if (PlantDelay.instance.done == true && InRange.instance.inRange == true)
        {
            lookUp = plotLocation + plantType;
            croptoHarvest = GameObject.Find(lookUp);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(plotLocation + plantType);
                if (croptoHarvest != null)
                {
                    croptoHarvest.SetActive(false);
                    isHarvested = true;
                }
            }

        }


    }
    
  

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "B1")
        {
            plotLocation = "B1 ";
        } else if (other.gameObject.tag == "B2")
        {
            plotLocation = "B2 ";
        } else if (other.gameObject.tag == "B3")
        {
            plotLocation = "B3 ";
        } else if (other.gameObject.tag == "B4")
        {
            plotLocation = "B4 ";
        } else if (other.gameObject.tag == "A1")
        {
            plotLocation = "A1 ";
        } else if (other.gameObject.tag == "A2")
        {
            plotLocation = "A2 ";
        } else if (other.gameObject.tag == "A3")
        {
            plotLocation = "A3 ";
        } else if (other.gameObject.tag == "A4")
        {
            plotLocation = "A4 ";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            plotLocation = "";
            croptoHarvest = null;
        }
    }
}
