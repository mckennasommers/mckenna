﻿using UnityEngine;
using System.Collections;

public class Script1 : MonoBehaviour 
{
	
	public int myInt = 5;


	void Start () 
	{
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt);
	}

	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
