/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{



    //IChangeColorBehavior had to be changed to an abstract class to extend MonoBehaviour
    //so it could be called with    Destroy(GetComponent<ChangeColorBehavior>());
    //in the Enemy script.
    //This is because interfaces cannot extend MonoBehaviour.
    //And GetComponent<type>() can only be called on classes that extend MonoBehaviour.
    public abstract class ChangeColorBehavior : MonoBehaviour
    {
        public abstract void ChangeColor();
    }

    public abstract class AttackBehavior : MonoBehaviour
    {
        public abstract void Attack();

    }
    public abstract class SpecialAbilityBehavior : MonoBehaviour
    {
        public abstract void SpecialAbility();

    }

}