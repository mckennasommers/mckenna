using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour
	{
		int apples = 4;


		void Start ()
		{
			while(apples > 0)
			{
				Debug.Log ("I have lots of apples!");
				apples--;
			}
		}
	}

