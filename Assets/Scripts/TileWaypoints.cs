using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileWaypoints : MonoBehaviour
{       

    [SerializeField] bool isPlaceable;
         void OnMouseDown(){
             if(isPlaceable){
                 Debug.Log("Is Placeable");
             }
            else{
                Debug.Log("Is not placeable");
            }
         }
}
