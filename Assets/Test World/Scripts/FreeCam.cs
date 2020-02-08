using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCam : MonoBehaviour
{
	public float turningSpeed = 60;
	public bool autoLockCursor;

	void Awake()
	{
		Cursor.lockState = (autoLockCursor) ? CursorLockMode.Locked : CursorLockMode.None;
	}
	void Update()
	{
		float horizontal = Input.GetAxis("Mouse X") * turningSpeed * Time.deltaTime;
		transform.Rotate(0, horizontal, 0);

		float verticle = Input.GetAxis("Mouse Y") * (turningSpeed/4) * Time.deltaTime;
		transform.Rotate(0, verticle, 0);


		if (Cursor.lockState == CursorLockMode.None && Input.GetMouseButtonDown(0))
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
		else if (Cursor.lockState == CursorLockMode.Locked && Input.GetKeyDown(KeyCode.Escape))
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
