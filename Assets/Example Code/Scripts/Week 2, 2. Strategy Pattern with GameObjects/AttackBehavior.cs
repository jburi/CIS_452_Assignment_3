/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{

    public class AttackPunch : AttackBehavior
    {
        public override void Attack()
        {
            Debug.Log("The enemy punches you!");

            GetComponent<MeshRenderer>().material.color = Color.red;
            

        }
    }

    public class AttackBite : AttackBehavior
    {
        public override void Attack()
        {
            Debug.Log("The enemy bites you!");
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }

    public class AttackLaser : AttackBehavior
    {
        public override void Attack()
        {
            Debug.Log("The enemy shoots you with a LASER BEAM!");
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

}