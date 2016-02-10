using UnityEngine;
using System.Collections;

public class DoWhile : MonoBehaviour {

	void Start()
	{
		bool shouldContinue = false;

		do
		{
			print ("Hey!");

		}while(shouldContinue == true);
	}
}