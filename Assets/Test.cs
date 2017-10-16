using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {
	private int hp = 100;
	private int power = 25;

	public void Attack() {
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence (int damage) {
		Debug.Log (damage + "のダメージを受けた");

		this.hp -= damage;
	}
}

public class Test : MonoBehaviour {



	// Use this for initialization
	void Start () {
		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Defence (3);

		Boss midboss = new Boss ();

		midboss.Attack ();
		midboss.Defence (9);
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
