using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CropTracker : MonoBehaviour
{
    [HideInInspector]
    public int carrottot;
    [HideInInspector]
    public int potatotot;
    [HideInInspector]
    public int eggplanttot;
    [HideInInspector]
    public int pepperstot;
    [HideInInspector]
    public int pumpkintot;
    [HideInInspector]
    public int beetstot;
    
    public int numToPrint;
    public string totint;
    public string numToPrintint;
    public int xp;
   
    //These  control which plot is being interacted with and the plant type
    public string plantType;
    public string plotLocation;
    public string lookUp;
    public GameObject croptoHarvest;

    public static CropTracker instance;

    public bool isHarvested=false;
    public bool isHarvestedKin = false;
    public bool inRange = false;

    //this stuff is important
    [HideInInspector]
    public string manager;
    public GameObject managerSpecific;

    //message that appears when you harvest
    public GameObject signBoardandMessage;
    public TextMeshProUGUI Message;

    //Inventory stuff
    public GameObject InventoryUI;
    public TextMeshProUGUI carrotSeed;
    public TextMeshProUGUI potatoSeed;
    public TextMeshProUGUI eggplantSeed;
    public TextMeshProUGUI pepperSeed;
    public TextMeshProUGUI pumpkinSeed; 
    public TextMeshProUGUI beetSeed;
    public int carrotseed = 0;
    public int potatoseed = 0;
    public int eggplantseed = 0;
    public int pepperseed = 0;
    public int pumpkinseed = 0;
    public int beetseed = 0;
    [HideInInspector]
    public string carrotSeedString;
    [HideInInspector]
    public string potatoSeedString;
    [HideInInspector]
    public string eggplantSeedString;
    [HideInInspector]
    public string pepperSeedString;
    [HideInInspector]
    public string pumpkinSeedString;
    [HideInInspector]
    public string beetSeedString;
    public TextMeshProUGUI carrotI;
    public TextMeshProUGUI potatoI;
    public TextMeshProUGUI eggplantI;
    public TextMeshProUGUI pepperI;
    public TextMeshProUGUI pumpkinI;
    public TextMeshProUGUI beetI;
    [HideInInspector]
    public string carrotString;
    [HideInInspector]
    public string potatoString;
    [HideInInspector]
    public string eggplantString;
    [HideInInspector]
    public string pepperString;
    [HideInInspector]
    public string pumpkinString;
    [HideInInspector]
    public string beetString;
    public AudioSource audioSource;
    public AudioClip audioClip;


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
                        audioSource.PlayOneShot(audioClip);
                        Debug.Log(plotLocation + plantType);
                        managerSpecific.GetComponent<PlantDelay>().stage3.SetActive(false);
                        isHarvested = true;
                        isHarvestedKin = true;
                        signBoardandMessage.SetActive(true);
                        Plant();
                        Message.text = "+" + numToPrintint +" " + plantType + "s.";
                        StartCoroutine(Waiting());

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
                this.GetComponent<plant_seed>().planted_kin = false;
                managerSpecific.GetComponent<PlantDelay>().hasCrop = false;
            }
        }

        //pulls up inventory
        if (Input.GetKeyDown(KeyCode.Tab) && InventoryUI.activeSelf==false)
        {
            InventoryUI.SetActive(true);
            InventoryNumbers();
           
        } else if (Input.GetKeyDown(KeyCode.Tab) && InventoryUI.activeSelf == true)
        {
            InventoryUI.SetActive(false);
           
        }

    }

    void InventoryNumbers()
    {
        //seed
        carrotSeedString = carrotseed.ToString("0");
        carrotSeed.text = carrotSeedString;
        potatoSeedString = potatoseed.ToString("0");
        potatoSeed.text = potatoSeedString;
        eggplantSeedString = eggplantseed.ToString("0");
        eggplantSeed.text = eggplantSeedString;
        pepperSeedString = pepperseed.ToString("0");
        pepperSeed.text = pepperSeedString;
        pumpkinSeedString = pumpkinseed.ToString("0");
        pumpkinSeed.text = pumpkinSeedString;
        beetSeedString = beetseed.ToString("0");
        beetSeed.text = beetSeedString;

        //crop
        carrotString = carrottot.ToString("0");
        carrotI.text = carrotString;
        potatoString = potatotot.ToString("0");
        potatoI.text = potatoString;
        eggplantString = eggplanttot.ToString("0");
        eggplantI.text = eggplantString;
        pepperString = pepperstot.ToString("0");
        pepperI.text = pepperString;
        pumpkinString = pumpkintot.ToString("0");
        pumpkinI.text = pumpkinString;
        beetString = beetstot.ToString("0");
        beetI.text = beetString;
    }

     IEnumerator Waiting()
    {
        yield return new WaitForSeconds(2);
        signBoardandMessage.SetActive(false);
    }
   void Plant()
    {
        if (plantType == "carrot")
        {
            carrottot += 12;
            numToPrint = 12;
            totint = carrottot.ToString("0");
            xp = 10;

            
        } else if (plantType == "eggplant")
        {
            eggplanttot += 24;
            numToPrint = 24;
            xp = 15;
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
            xp = 5;
            totint = pepperstot.ToString("0");
        } else if (plantType == "beet")
        {
            beetstot += 20;
            numToPrint = 20;
            xp = 10;
            totint = beetstot.ToString("0");
        } else if (plantType == "pumpkin")
        {
            pumpkintot += 4;
            numToPrint = 4;
            totint = pumpkintot.ToString("0");
            xp = 60;
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
