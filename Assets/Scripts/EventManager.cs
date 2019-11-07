using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
	public delegate void OnButtonClick (); // declare delegate.
	public static event OnButtonClick onButtonClick; // initialize delegate / event.

	public void RaiseOnButtonClick () // built int function for button clicks
	{
		if (onButtonClick != null) { // if there is a subscriber to the event 
			onButtonClick (); // call the event delegate
		}
	}
}


// delegate declaration == public delegate void NameOfDelegate
// event initialization == public static event NameOfDelegateType NameOfEvent;


//public void  myAction(){
//if (NameOfEvent != null)
//{
//NameOfEvent ();
	//}

	// }
