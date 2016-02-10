using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

	void Start () 
	{
		string[] strings = new string[3];

		strings[0] = "1";
		strings[1] = "2";
		strings[2] = "3";

		foreach(string item in strings)
		{
			print (item);
		}
	}
}
