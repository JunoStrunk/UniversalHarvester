using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_seed : MonoBehaviour
{
    public GameObject Inventory_UI;
   
    public string plotLoc;
    public string toGrow;
    public GameObject lookUp;
    public GameObject managerS;

    public bool planted_kin = false;
    private void Update()
    {
        if (CropTracker.instance.inRange == true)
        {
            managerS = CropTracker.instance.managerSpecific;
        }
    }
  
    void OnTriggerEnter(Collider collider)
    {  
        if (collider.tag == "B1" || collider.tag == "B2" || collider.tag == "B3" || collider.tag == "B4" || collider.tag == "A1" || collider.tag == "A2" || collider.tag == "A3" || collider.tag == "A4")
        {
            if (planted_kin == false && managerS.GetComponent<PlantDelay>().hasCrop==false)
            {
                Inventory_UI.SetActive(true);
            }
        }
    }

    public void PlantCarrot()
    {
        plotLoc = CropTracker.instance.plotLocation;
        toGrow = plotLoc + "carrot";
        lookUp = GameObject.Find(toGrow);
        if (plotLoc != null)
        {
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 = lookUp.transform.GetChild(0).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage2 = lookUp.transform.GetChild(1).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage3 = lookUp.transform.GetChild(2).gameObject;
            Debug.Log(CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1);
            if (CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 == null)
            {

            }
            Debug.Log("Planted carrots in plot " + plotLoc);
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().planted = true;
            planted_kin = true;

            Inventory_UI.SetActive(false);
        }
    }

    public void PlantPotatoes()
    {
        plotLoc = CropTracker.instance.plotLocation;
        toGrow = plotLoc + "potato";
        lookUp = GameObject.Find(toGrow);
        if (plotLoc != null)
        {
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 = lookUp.transform.GetChild(0).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage2 = lookUp.transform.GetChild(1).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage3 = lookUp.transform.GetChild(2).gameObject;
            Debug.Log(CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1);
            if (CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 == null)
            {

            }
            Debug.Log("Planted potatoes in plot " + plotLoc);
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().planted = true;
       
            planted_kin = true;
            Inventory_UI.SetActive(false);
        }
    }

    public void PlantEggplant()
    {
        plotLoc = CropTracker.instance.plotLocation;
        toGrow = plotLoc + "eggplant";
        lookUp = GameObject.Find(toGrow);
        if (plotLoc != null)
        {
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 = lookUp.transform.GetChild(0).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage2 = lookUp.transform.GetChild(1).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage3 = lookUp.transform.GetChild(2).gameObject;
            Debug.Log(CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1);
            if (CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 == null)
            {

            }
            Debug.Log("Planted eggplant in plot " + plotLoc);
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().planted = true;
            planted_kin = true;
            Inventory_UI.SetActive(false);
        }
    }

    public void PlantPeppers()
    {
        plotLoc = CropTracker.instance.plotLocation;
        toGrow = plotLoc + "pepper";
        lookUp = GameObject.Find(toGrow);
        if (plotLoc != null)
        {
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 = lookUp.transform.GetChild(0).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage2 = lookUp.transform.GetChild(1).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage3 = lookUp.transform.GetChild(2).gameObject;
            Debug.Log(CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1);
            if (CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 == null)
            {

            }
            Debug.Log("Planted peppers in plot " + plotLoc);
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().planted = true;
            planted_kin = true;
            Inventory_UI.SetActive(false);
        }
    }

    public void PlantPumpkin()
    {
        plotLoc = CropTracker.instance.plotLocation;
        toGrow = plotLoc + "pumpkin";
        lookUp = GameObject.Find(toGrow);
        if (plotLoc != null)
        {
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 = lookUp.transform.GetChild(0).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage2 = lookUp.transform.GetChild(1).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage3 = lookUp.transform.GetChild(2).gameObject;
            Debug.Log(CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1);
            if (CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 == null)
            {

            }
            Debug.Log("Planted pumpkin in plot " + plotLoc);
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().planted = true;
            planted_kin = true;
            Inventory_UI.SetActive(false);
        }
    }
    public void PlantBeets()
    {
        plotLoc = CropTracker.instance.plotLocation;
        toGrow = plotLoc + "beet";
        lookUp = GameObject.Find(toGrow);
        if (plotLoc != null)
        {
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 = lookUp.transform.GetChild(0).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage2 = lookUp.transform.GetChild(1).gameObject;
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage3 = lookUp.transform.GetChild(2).gameObject;
            Debug.Log(CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1);
            if (CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().stage1 == null)
            {

            }
            Debug.Log("Planted beets in plot " + plotLoc);
            CropTracker.instance.managerSpecific.GetComponent<PlantDelay>().planted = true;
            planted_kin = true;
            Inventory_UI.SetActive(false);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "B1" || col.tag == "B2" || col.tag == "B3" || col.tag == "B4" || col.tag == "A1" || col.tag == "A2" || col.tag == "A3" || col.tag == "A4")
        {
            Inventory_UI.SetActive(false);
        }
    }
}

