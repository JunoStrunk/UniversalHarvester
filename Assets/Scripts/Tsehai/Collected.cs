using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collected : MonoBehaviour
{
    // PUT THIS ON THE PLANT PARENT (preferably the plot)
    //THIS CONTROLS E
    // ik this is called collected but the actual harvesting is in CropTracker lol
    //it should be called E
    
    public bool inE=false;
    // public TextMeshProUGUI collect;
    public GameObject noClue;
    public GameObject E;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        noClue = CropTracker.instance.managerSpecific;
        if (noClue != null)
        {


            if (noClue.GetComponent<PlantDelay>().done == true && CropTracker.instance.inRange == true)
            {
                if (inE == true)
                {
                    E.SetActive(true);
                }
                else if (inE == false)
                {
                    E.SetActive(false);
                }


            }
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inE = true;
        }
      
    }
     void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            inE = false;
        }
    }
}
