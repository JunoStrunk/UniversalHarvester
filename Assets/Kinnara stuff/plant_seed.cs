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
    public bool taken;
    public bool inPlot;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public bool planted_kin = false;
     void Update()
    {
        if (CropTracker.instance.inRange == true)
        {
            managerS = CropTracker.instance.managerSpecific;
            taken = managerS.GetComponent<PlantDelay>().hasCrop;
            plotLoc = CropTracker.instance.plotLocation;
         
        }

        if (inPlot == true && taken ==false)
        {
            Inventory_UI.SetActive(true);
            //Was gonna have random sound play but my headache is coming back so :melting emoji:
            //int num = Random.Range(0, audioClip.Length);

        } else if (inPlot == false || taken ==true)
        {
            Inventory_UI.SetActive(false);
        }
        
    }
  
    void OnTriggerEnter(Collider collider)
    {  
        if (collider.gameObject.tag == "B1" || collider.tag == "B2" || collider.tag == "B3" || collider.tag == "B4" || collider.tag == "A1" || collider.tag == "A2" || collider.tag == "A3" || collider.tag == "A4")
        {
            inPlot = true;
           /* Debug.Log("Entered " + plotLoc);
            if (taken == false)
            {
                Debug.Log("There are no crops in " + plotLoc);
                Inventory_UI.SetActive(true);

            } else if (taken == true)
            {
                Debug.Log("There is a crop in " + plotLoc);
                Inventory_UI.SetActive(false);
            } */

        }
    }

    public void PlantCarrot()
    {
       // audioSource.clip = audioClip[toPlay];
        audioSource.PlayOneShot(audioClip);
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
        audioSource.PlayOneShot(audioClip);
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
        audioSource.PlayOneShot(audioClip);
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
        audioSource.PlayOneShot(audioClip);
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
        audioSource.PlayOneShot(audioClip);
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
        audioSource.PlayOneShot(audioClip);
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
            inPlot = false;
              /*  Inventory_UI.SetActive(false);
            Debug.Log("exited " + plotLoc); */
        }
    }
}

