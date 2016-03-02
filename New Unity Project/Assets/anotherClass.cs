using UnityEngine;
using System.Collections;

public class anotherClass : MonoBehaviour {

	public int square;
	public int circle;


	private int pencil;
	private int paper;


	public void Shape (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Shape total: " + answer);
	}


	private void OfficeSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Office Supplies total: " + answer);
	}
}
