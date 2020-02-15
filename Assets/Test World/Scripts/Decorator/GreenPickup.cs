using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPickup : BattleshipDecorator
{
	Battleship _battleship;

	public GreenPickup(Battleship ship)
	{
		this._battleship = ship;
	}

	public override float MovementSpeed()
	{
		return _battleship.MovementSpeed() + 5;
	}
}
