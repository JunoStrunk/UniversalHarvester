using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plant_seed : MonoBehaviour
{
    public GameObject inventory_UI;
    bool planted = false;
    public GameObject carrots;
    public GameObject potatoes;
    public GameObject eggplant;
    public GameObject peppers;
    public GameObject cucumbers;
    public GameObject beets;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "mound" && !planted)
        {
            inventory_UI.SetActive(true);
        }
    }

    public void PlantCarrot()
    {
        carrots.SetActive(true);
    }

    public void PlantPotatoes()
    {
        potatoes.SetActive(true);
    }

    public void PlantEggplant()
    {
        eggplant.SetActive(true);
    }

    public void PlantPeppers()
    {
        peppers.SetActive(true);
    }

    public void PlantCucumbers()
    {
        cucumbers.SetActive(true);
    }

    public void PlantBeets()
    {
        beets.SetActive(true);
    }
}
