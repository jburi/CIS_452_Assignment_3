/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{
    public class EnemyRobot : Enemy
    {
        //Now that Enemy extends Monobehavior,
        //it is better to use Awake() than a constructor
        public void Awake()
        {
            //And we use gameObject.AddComponent<ChangeColorBlue>(); instead of new
            //to add the ChageColorBlue script/class to the EnemySpider on Awake()
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorBlue>();

            AttackBehavior = gameObject.AddComponent<AttackLaser>();
            SpecialAbilityBehavior = gameObject.AddComponent<SpecialAbilityBodySlam>();

        }

        public override void Die()
        {
            Debug.Log("The robot dies.");
            //add death animations and particle effects for robot death here
            Destroy(gameObject);
        }
    }
}
