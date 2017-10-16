using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 50, 60, 40, 70, 10 };

		for (int i = array.Length-1; 0 <= i; i--) {

			Debug.Log (array [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
