using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FarmFactSign : MonoBehaviour
{
	[SerializeField]
	float waitTime = 10;
	List<string> farmFacts = new List<string>();
	TextMeshProUGUI signText;
	Animator anim;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		farmFacts.Add("The cost of fertilizer increased by more than 60% from 2021 to 2022. (American Farm Bureau Registration)");
		farmFacts.Add("There is a national shortage of farmworkers in the US, but the H-2A visa system that facilitates foreign workers often forces them to pay to work.");
		farmFacts.Add("Practices like rotational cattle grazing have helped cattle ranchers keep carbon emissions down and fight climate change. The government has now started paying farmers for these practices.");
		farmFacts.Add("Effects of climate change like extreme floods have greatly impacted farming today. Floods damage crops and erode the soil, leaving little yield and barren fields. (FAO)");
		farmFacts.Add("Access to technology is a large hurdle for many smaller farmers, especially in places that lack infrastructure. (World Bank)");
		farmFacts.Add("During the start of the Covid-19 pandemic, there was a large jump in boxed beef purchases. People rushing to buy groceries injected volatility into market for farmers.");
		farmFacts.Add("The Asian Citrus Psyllid is an invasive beetle to citrus fruits that make them misshapen and bitter. It is recommended to kill these beetles on sight! (USDA)");
		farmFacts.Add("With good soil, weather, and conscientious management, one acre can produce 8,000 pounds of broccoli, 26,000 pounds of carrots, or 30,000 pounds of field tomatoes in a growing season.");
		farmFacts.Add("A farmer in Italy grew a 2,702-pound squash in 2021, taking the record for largest pumpkin grown. (NPR)");
		farmFacts.Add("Cows can form friendships with other cows! Compared to a stranger cow, cows that are friends have lower heart rates and stress levels when they are around each other.");

		signText = this.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
		anim = this.GetComponent<Animator>();
	}

	public void GetFarmFact()
	{
		int randNum = Random.Range(0, farmFacts.Count);

		signText.text = farmFacts[randNum];

		anim.Play("SignAnimation");
		StartCoroutine(DelaySignAnimation());
	}

	IEnumerator DelaySignAnimation()
	{
		yield return new WaitForSeconds(waitTime);
		anim.Play("SignAnimation_LEAVING");
	}
}
