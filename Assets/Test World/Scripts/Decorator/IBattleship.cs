using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IBattleship
{
	public float movementSpeed = 10f;
	public virtual float MovementSpeed()
	{
		return movementSpeed;
	}
}
