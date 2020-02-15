using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
	public float camRayLength = 1000f;
	public float turningSpeed = 50;

	// Update is called once per frame
	void Update()
	{
		Turning();
	}

	void Turning()
	{
		GameObject turret = gameObject;

		//Turn Right
		if (Input.GetKey("e"))
		{
			float horizontal = turningSpeed * Time.deltaTime;
			float negHorizontal = -turningSpeed * Time.deltaTime;
			if (gameObject.name == "Large Turret") { turret.transform.Rotate(0, horizontal, 0); }
			else if (gameObject.name == "Medium Turret") { turret.transform.Rotate(0, negHorizontal, 0); }
		}
		//Turn Left
		if (Input.GetKey("q"))
		{
			float horizontal = -turningSpeed * Time.deltaTime;
			float negHorizontal = turningSpeed * Time.deltaTime;
			if (gameObject.name == "Large Turret") { turret.transform.Rotate(0, horizontal, 0); }
			else if (gameObject.name == "Medium Turret") { turret.transform.Rotate(0, negHorizontal, 0); }
		}

	}

}
