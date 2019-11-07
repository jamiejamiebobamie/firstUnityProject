using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionary : MonoBehaviour
{
	private void Start ()
	{
		Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy> ();

		BadGuy bg1 = new BadGuy ("Harvey", 50);
		BadGuy bg2 = new BadGuy ("hey", 1);

		badguys.Add ("batman", bg1);
		badguys.Add ("test", bg2);

		BadGuy notMagneto = badguys ["batman"];

		BadGuy temp = null;

		if (badguys.TryGetValue("batman", out temp))
		{
			print (temp.villian);

		} else {
			print ("uh oh");
		}

	}
}
