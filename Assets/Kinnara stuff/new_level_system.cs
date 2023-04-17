using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class new_level_system : MonoBehaviour
{
    public Image xp_bar;
    public float current_xp = 0;
    public float required_xp = 100;
    public int level = 0;
    public Text level_name;


    // Start is called before the first frame update
    void Start()
    {
        xp_bar.fillAmount = current_xp / required_xp;
        Debug.Log("Start, " + xp_bar.fillAmount);
        level_name.text = "Level: " + (level + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (current_xp >= required_xp)
        {
            level++;
            required_xp = required_xp + (50 * (level));
            xp_bar.fillAmount = 0;
            current_xp = 0;
            level_name.text = "Level: " + (level + 1);
        }
        if (CropTracker.instance.isHarvestedKin==true)
        {
            current_xp += CropTracker.instance.xp;
            Debug.Log(CropTracker.instance.xp);
            xp_bar.fillAmount = current_xp / required_xp;
            Debug.Log("Harvested, " + xp_bar.fillAmount);
            CropTracker.instance.isHarvestedKin = false;
        }
    }
}
