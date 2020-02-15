using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePickup : BattleshipDecorator
{
	public override float MovementSpeed(IBattleship _battleship) 
		:base(Battleship)
	{
		return _battleship.MovementSpeed() + _speed;
	}
}
public class GreenPickup : BattleshipDecorator
{
	public override float MovementSpeed(IBattleship _battleship)
	{
		return _battleship.MovementSpeed() + _speed;
	}
}
