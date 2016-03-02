using UnityEngine;
using System.Collections;

public class dataTypes : MonoBehaviour {

	void Start () 
	{
		//value
		Vector3 pos = transform.position;
		pos = new Vector3(0, 2, 0);

		//Reference
		Transform tran = transform;
		tran.position = new Vector3(0, 2, 0);
	}
}
