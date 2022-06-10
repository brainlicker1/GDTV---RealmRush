using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
    {       
        
        [SerializeField] Transform weapon;
        [SerializeField] float range = 15f;
        [SerializeField] ParticleSystem projectileParticles;
     Transform target;
    
    

    
    void Update()
    {       FindNearestTarget();
            AimWeapon();
    }

     void FindNearestTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Transform closestTarget = null;
        float maxDistance = Mathf.Infinity;

        foreach(Enemy enemy in enemies){

            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if( targetDistance < maxDistance) {
                target = enemy.transform;
                maxDistance = targetDistance;
            }

            target = closestTarget;
        }
    }

    void AimWeapon(){
        float targetDistance = Vector3.Distance(transform.position, target.position);
        weapon.LookAt(target);

        if(targetDistance < range){
            Attack(true);
        } else {
            Attack(false);
        }
        

    }
    void Attack(bool isActive)
    {
        var emmissionModule = projectileParticles.emission;
        emmissionModule.enabled = isActive;


    }
}
