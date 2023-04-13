using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldItem : MonoBehaviour
{
	public GameObject heldItem;
	GameObject heldRef;
	bool holding;
	bool canPickUp;

	void Start()
	{
		heldItem = null;
		heldRef = null;
		holding = false;
		canPickUp = false;
	}

	void Update()
	{
		if (canPickUp && Input.GetKeyDown(KeyCode.E))
		{
			heldItem = heldRef;
			heldRef.transform.SetParent(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Plant") && heldItem == null)
		{
			canPickUp = true;
			heldRef = col.gameObject;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.CompareTag("Plant"))
		{
			canPickUp = false;
			heldRef = null;
		}

	}
}
