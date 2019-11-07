using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransformAndColor : MonoBehaviour
{
	public MeshRenderer meshRenderer;
	public Color color1, color2;

	private void Start ()
	{
		color1 = Color.blue;
		color2 = Color.red;

		meshRenderer = gameObject.GetComponent<MeshRenderer> ();
	}


	private void OnEnable ()
	{
		EventManager.onButtonClick += ChangePosition;
		EventManager.onButtonClick += ChangeColor;
	}
	private void OnDisable ()
	{
		EventManager.onButtonClick -= ChangePosition;
		EventManager.onButtonClick -= ChangeColor;
	}
	public void ChangePosition ()
	{
		transform.position += Vector3.one * 2;
	}
	public void ChangeColor ()
	{
		meshRenderer.material.color = color2;
	}
}

