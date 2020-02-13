using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    public class AICharacterControl1 : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }  // the navmesh agent required for the path finding
        public AIBattleship character { get; private set; }				// the character we are controlling
        public Transform target;										// target to aim for

		private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<AIBattleship>();

	        agent.updateRotation = true;
	        agent.updatePosition = true;
        }


        private void Update()
        {
            if (target != null)
                agent.SetDestination(target.position);

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity);
            else
                character.Move(Vector3.zero);
		}


        public void SetTarget(Transform target)
        {
            this.target = target;
        }

	}
}
