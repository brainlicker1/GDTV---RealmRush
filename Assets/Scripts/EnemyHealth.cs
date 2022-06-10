using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{   
    [SerializeField] int maxHP = 5;
    [SerializeField] int currentHealth = 0;
    //int currentHealth = 0;
    // Start is called before the first frame update
             void Start() {
            currentHealth = maxHP;
        }
   void OnParticleCollision(GameObject other)  {
        
        ProcessHit();
            
    }
         void ProcessHit(){
              currentHealth--;

         if(currentHealth <= 0) {
             gameObject.SetActive(false);
         }
         }
     
}
