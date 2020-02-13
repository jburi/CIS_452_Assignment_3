using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleship : MonoBehaviour, iTurret
{
	public int m_PlayerNumber = 1;              // Used to identify the different players.
	public float movementSpeed = 10;
	public float turningSpeed = 60;
	private float m_TurnAmount;
	private float m_ForwardAmount;

	void Update()
	{
		float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
		transform.Rotate(0, horizontal, 0);

		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate(0, 0, vertical);
	}

	public void Move(Vector3 move)
	{
		if (move.magnitude > 1f) move.Normalize();
		move = transform.InverseTransformDirection(move);
		m_TurnAmount = Mathf.Atan2(move.x, move.z);
		m_ForwardAmount = move.z;
	}

	public void RegisterObserver(iTurret observer)
	{
		throw new System.NotImplementedException();
	}

	public void RemoveObserver(iTurret observer)
	{
		throw new System.NotImplementedException();
	}

	public void NotifyObservers()
	{
		throw new System.NotImplementedException();
	}

	public void Turning()
	{
		throw new System.NotImplementedException();
	}
}
