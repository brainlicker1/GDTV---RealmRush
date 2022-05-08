using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileWaypoints : MonoBehaviour
{       
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceable;
         void OnMouseDown(){
             if(isPlaceable){
                 Instantiate(towerPrefab, transform.position, Quaternion.identity);
             }
            else{
                Debug.Log("Is not placeable");
            }
         }
}
