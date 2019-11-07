using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegates_test : MonoBehaviour
{
	delegate void MyDelegate (); // any function that shares this method signature can be assigned to MyDelegate
	MyDelegate myDelegate; // initialization of MyDelegate-type variable.

	// CALLING A DELEGATE THAT HAS NOT BEEN ASSIGNED ANY FUNCTIONS WILL RESULT IN AN ERROR!
	// so good practice is to...

	private void Start ()
	{
		// delegates that have not been assigned any methods are null
		if (myDelegate != null)
		{
			myDelegate();
		}
	}
}
