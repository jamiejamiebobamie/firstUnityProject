using System.Collections;
using System.Collections.Generic; // MUST BE INCLUDED To USE LIST
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    void Start()
	{
		List<BadGuy> badguys = new List<BadGuy>();

		badguys.Add(new BadGuy("Harvey", 50)); // adds an element to the END of the list
		badguys.Add(new BadGuy("hey", 2));

		print(badguys.Count); // like length method
					   //badguys. // check out all of the methods associated with the list data type with VScode autocomplete!

		// one of the most powerful methods of the list is the sort method, but it requires that the data type
		// that is being stored by the list to implement the interface IComparable


		foreach (BadGuy guy in badguys)
		{
			print(guy.villian + " " + guy.power);
		}

		badguys.Sort();

        foreach(BadGuy guy in badguys)
		{
			print(guy.villian + " " + guy.power);
		}
	}
}
