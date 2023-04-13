using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantDelay : MonoBehaviour
{
    //PUT THIS ON A MANAGER
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public string plantname;
    public bool done=false;
    public static PlantDelay instance;


    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(stage1.gameObject.name== "SM_Prop_Carrot_01_S")
        {
            plantname = "carrot";
        } else if (stage1.gameObject.name == "SM_Prop_Eggplant_01_S")
        {
            plantname = "eggplant";
        } else if (stage1.gameObject.name == "SM_Prop_Potato_01_S")
        {
            plantname = "potato";
        }

        if (timer >= 0 && timer<15)
        {
            timer += Time.deltaTime;
        }

        if (timer>=0 && timer < 5)
        {
            stage1.SetActive(true);
            stage2.SetActive(false);
            stage3.SetActive(false);

        }
        if (timer >= 5 && timer < 10)
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
            stage3.SetActive(false);
        }
        if (timer >= 10 && timer < 15)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(true);
            done = true;
            
        }

        
        

        // StartCoroutine(GrowthOne());
        /*  if (one == true)
          {
              Debug.Log("Stage 1");
              stage1.SetActive(true);
              StartCoroutine(Control());
              one = false;
              two = true;
              stage1.SetActive(false);
          } else if (two == true)
          {
              Debug.Log("Stage 2");
              stage2.SetActive(true);
              StartCoroutine(Control());
              two = false;
              three = true;
              stage2.SetActive(false);
          } else if (three == true)
          {
              Debug.Log("Stage 3");
              stage3.SetActive(true);
              StartCoroutine(Control());
              three = false;

          } */


    }

    IEnumerator Control()
    {
        yield return new WaitForSeconds(5);
    }
    IEnumerator GrowthOne()
    {
        Debug.Log("STAGE 1 GROWTH");
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
        yield return new WaitForSeconds(5);
        StartCoroutine(GrowthTwo());

    }
    IEnumerator GrowthTwo()
    {
        Debug.Log("STAGE 2 GROWTH");
        stage1.SetActive(false);
        stage2.SetActive(true);
        stage3.SetActive(false);
        yield return new WaitForSeconds(5);
        StartCoroutine(GrowthThree());

    }
    IEnumerator GrowthThree()
    {
        
        yield return new WaitForSeconds(5);
        Debug.Log("STAGE 3 GROWTH");
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(true);

    }

}
