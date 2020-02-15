using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePickup : BattleshipDecorator
{
	Battleship _battleship;

	public BluePickup(Battleship ship)
	{
		this._battleship = ship;
	}

	public override float MovementSpeed()
	{
		return _battleship.MovementSpeed() + 1;
	}
}
