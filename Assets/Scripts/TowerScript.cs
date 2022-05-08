using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{       
    [SerializeField] Transform weapon;
     Transform target;
    
    void Start()
    {
        target = FindObjectOfType<EnemyMovement>().transform;
        
    }

    
    void Update()
    {
            AimWeapon();
    }
    void AimWeapon(){

        weapon.LookAt(target);


    }
}
