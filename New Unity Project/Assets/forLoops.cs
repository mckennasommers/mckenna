using UnityEngine;
using System.Collections;

public class forLoops : MonoBehaviour {

		int myNumber = 2;


		void Start ()
	{
		for (int i = 0; i < myNumber; i++) {
			Debug.Log ("My Number: " + i);
		}
	}
		}