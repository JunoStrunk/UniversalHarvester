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

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "plot")
        {
            Inventory_UI.SetActive(true);
        }
    }

    public void PlantCarrot()
    {
        Debug.Log("Planted carrots");
        carrots.SetActive(true);
        //planted = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantPotatoes()
    {
        potatoes.SetActive(true);
        //planted = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantEggplant()
    {
        eggplant.SetActive(true);
        //planted = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantPeppers()
    {
        peppers.SetActive(true);
        //planted = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantCucumbers()
    {
        cucumbers.SetActive(true);
        //planted = true;
        Inventory_UI.SetActive(false);
    }

    public void PlantBeets()
    {
        beets.SetActive(true);
        //planted = true;
        Inventory_UI.SetActive(false);
    }
}
