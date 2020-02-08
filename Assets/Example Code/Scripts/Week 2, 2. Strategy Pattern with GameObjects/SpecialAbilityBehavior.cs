/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{

    public class SpecialAbilityBodySlam : SpecialAbilityBehavior
    {
        public override void SpecialAbility()
        {
            Debug.Log("The enemy slams you with its body!");
        }
    }

    public class SpecialAbilityWebSpray : SpecialAbilityBehavior
    {
        public override void SpecialAbility()
        {
            Debug.Log("The enemy sprays you with sticky webs!");
        }
    }

}