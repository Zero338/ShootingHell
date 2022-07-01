using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Move;
using RPG.Core;

namespace RPG.Combat
{
    public class Fighter:MonoBehaviour, IAction
    {
        [SerializeField]
        float weaponRange = 2f;
        [SerializeField]
        float timeBetweenAttacks = 1f;
       

        Transform target;
        float timeSinceLastAttack = 0;

        private void Start()
        {
            
        }
        private void Update()
        {
            timeSinceLastAttack += Time.deltaTime;

            if (target == null) return;
            if (!GetIsInRange())
            {
                GetComponent<Movement>().MoveTo(target.position);
            }
            else
            {
                GetComponent<Movement>().Cancel();
                Attacking();
            }
        }

        private void Attacking()
        {
            if(timeSinceLastAttack > timeBetweenAttacks)
            {
                GetComponent<Animator>().SetTrigger("Attack");
                
                
                
                timeSinceLastAttack = 0;
            }
            
        }

        private bool GetIsInRange()
        {
            return Vector3.Distance(transform.position, target.position) < weaponRange;
        }

        public void Attack(CombatTarget combatTarget)
        {
            GetComponent<ActionScheduler>().StartAction(this);
            target = combatTarget.transform;
        }
        public void Cancel()
        {
            target = null;
        }

        //Animation Event
        void Hit()
        {

        }

    }
}
