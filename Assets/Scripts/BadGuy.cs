using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BadGuy : IComparable<BadGuy>
{
	public string villian;
	public int power;

	public BadGuy(string newName, int newPower)
	{
		villian = newName;
		power = newPower;
	}


	public int CompareTo(BadGuy other)
	{
		if (other == null) {
			return 1;
		}

		return power - other.power;

		// equal returns a 0
		// greater than returns a 1
		// less than returns a -1
	}
}
