using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPickup : BattleshipDecorator
{
	Battleship _battleship;

	public RedPickup(Battleship ship)
	{
		this._battleship = ship;
	}

	public override float MovementSpeed()
	{
		return _battleship.MovementSpeed() - 5;
	}
}
