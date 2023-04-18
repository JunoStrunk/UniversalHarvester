using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_seed : MonoBehaviour
{
    public GameObject Inventory_UI;
    public GameObject carrots;
    public GameObject potatoes;
    public GameObject eggplant;
    public GameObject peppers;
    public GameObject cucumbers;
    public GameObject beets;
    public string plotLoc;
    public string toGrow;
    public GameObject lookUp;

   public bool planted_kin = false;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "B1"||collider.tag=="B2"||collider.tag=="B3"||collider.tag=="B4"||collider.tag=="A1"||collider.tag=="A2"||collider.tag=="A3"||collider.tag=="A4")
        {
            if (planted_kin==false)
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
            // carrots.SetActive(true);
            planted_kin = true;

            Inventory_UI.SetActive(false);
        }
    }

    public void PlantPotatoes()
    {
        potatoes.SetActive(true);
        planted_kin = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantEggplant()
    {
        eggplant.SetActive(true);
        planted_kin = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantPeppers()
    {
        peppers.SetActive(true);
        planted_kin = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantCucumbers()
    {
        cucumbers.SetActive(true);
        planted_kin = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantBeets()
    {
        beets.SetActive(true);
        planted_kin = true;
        Inventory_UI.SetActive(false);
    }
}
