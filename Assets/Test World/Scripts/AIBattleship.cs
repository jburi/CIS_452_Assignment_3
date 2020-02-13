using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBattleship : MonoBehaviour
{
	private float m_TurnAmount;
	private float m_ForwardAmount;

	public void Move(Vector3 move)
	{
		if (move.magnitude > 1f) move.Normalize();
		move = transform.InverseTransformDirection(move);
		m_TurnAmount = Mathf.Atan2(move.x, move.z);
		m_ForwardAmount = move.z;
	}
}
