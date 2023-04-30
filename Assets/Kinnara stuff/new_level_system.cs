using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class new_level_system : MonoBehaviour
{
	public Image xp_bar;
	public float current_xp = 0;
	public float required_xp = 100;
	public float excess_xp = 0;
	public int level = 0;
	public TextMeshProUGUI level_name;

	public FarmFactSign sign;


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
		if (current_xp >= required_xp) //level up
		{
			level++;
			excess_xp = current_xp - required_xp;
			current_xp = excess_xp;
			required_xp = required_xp + (50 * (level));
			xp_bar.fillAmount = excess_xp / required_xp;
			level_name.text = "Level: " + (level + 1);
			sign.GetFarmFact();
		}
		if (CropTracker.instance.isHarvestedKin == true)
		{
			current_xp += CropTracker.instance.xp;
			Debug.Log(CropTracker.instance.xp);
			xp_bar.fillAmount = current_xp / required_xp;
			Debug.Log("Harvested, " + xp_bar.fillAmount);
			CropTracker.instance.isHarvestedKin = false;
		}
	}
}
