using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
	public EventManager e;


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.P)) {
			e.RaiseOnButtonClick ();                   // Function call to invoke an Event
		}
	}
}
