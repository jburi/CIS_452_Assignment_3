/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOPReview
{

    public abstract class Enemy
    {
       
        //abstract methods must be implemented by concrete sub-classes
        public abstract void Die();

        //Unlike interfaces, abstract classes can have concrete methods
        //These concrete methods are inherited by sub-classes
        public void speak() { Debug.Log("I'm an enemy. Fear me!"); }

    }

    public class EnemySpider : Enemy
    {
        public override void Die()
        {
            Debug.Log("The spider dies.");
            //add death animations and particle effects for spider death here
        }
    }

    public class EnemyBoxer : Enemy, ICanPunch
    {
        public override void Die()
        {
            Debug.Log("The boxer dies.");
            //add death animations and particle effects for boxer death here
        }

        public void Punch()
        {
            Debug.Log("The boxer punches.");
            //add punch animations and sound effects here
        }
    }

    public class EnemyRobot : Enemy, ICanPunch
    {
        public override void Die()
        {
            Debug.Log("The robot dies.");
            //add death animations and particle effects for robot death here
        }

        public void Punch()
        {
            Debug.Log("The robot punches.");
            //add punch animations and sound effects here
        }

    }

}