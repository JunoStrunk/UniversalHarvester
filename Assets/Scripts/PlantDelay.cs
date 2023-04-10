using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantDelay : MonoBehaviour
{
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    // Start is called before the first frame update
    void Start()
    {
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Delay());
       
    }

    IEnumerator Delay()
    {
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
        yield return new WaitForSeconds(5);
        stage1.SetActive(false);
        stage2.SetActive(true);
        stage3.SetActive(false);
        yield return new WaitForSeconds(5);
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(true);

    }
  
}
