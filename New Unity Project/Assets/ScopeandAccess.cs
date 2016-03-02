using UnityEngine;
using System.Collections;

public class ScopeandAccess : MonoBehaviour {

	public int one = 7;


	private int two = 3;
	private int three = 8;


	private anotherClass myOtherClass;


	void Start ()
	{
		one = 12;

		myOtherClass = new anotherClass();
		myOtherClass.Shape(one, myOtherClass.square);
	}


	void Example (int red, int blue)
	{
		int answer;
		answer = red * blue * one;
		Debug.Log(answer);
	}


	void Update ()
	{
		Debug.Log("One is set to: " + one);
	}
}
