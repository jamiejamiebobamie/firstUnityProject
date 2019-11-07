using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSetPosition : MonoBehaviour
{
	public PropertiesAndCoroutines coroutineScript;

	public GameObject floor;

	private void Start ()
	{
		floor = GameObject.FindGameObjectsWithTag ("floor")[0];
	}

	private void OnMouseDown ()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		Physics.Raycast (ray, out hit);

		if (hit.collider.gameObject == floor)
		{
			Vector3 newTarget = hit.point + new Vector3 (0, 0.5f, 0);
			coroutineScript.Target = newTarget;
		}
	}
}
