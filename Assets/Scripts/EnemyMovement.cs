using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<TileWaypoints> waypointPath = new List<TileWaypoints>();
    [SerializeField][Range(0f,5f)] float enemyMoveSpeed = 1f;
    //[SerializeField] float  travelPercentModifier = 0f;

     void OnEnable() {
          FindPath();
         ReturnToStart();
        StartCoroutine(PrintWaypoints());
    }
    void Start()
    {   
       
       
      
        
    }
    void FindPath(){
            waypointPath.Clear();
        GameObject[] waypoints = GameObject.FindGameObjectsWithTag("isPath");

        foreach(GameObject waypoint in waypoints) {
            waypointPath.Add(waypoint.GetComponent<TileWaypoints>());
        }
       // Destroy(gameObject);
    }

    void ReturnToStart(){

     transform.position = waypointPath[0].transform.position;

    }

    void Update()
    {
        
    }

    IEnumerator PrintWaypoints()
    {   
        foreach (TileWaypoints tilewaypoint in waypointPath)
        {   
            Vector3 startPosition = transform.position;
            Vector3 endPosition = tilewaypoint.transform.position;
            float travelPercent = 0f;
            //transform.position = tilewaypoint.transform.position;
           // yield return new WaitForSeconds(enemyMoveSpeed);
           
            transform.LookAt(endPosition);
           while(travelPercent < 1f){
               travelPercent += Time.deltaTime * enemyMoveSpeed;
               transform.position = Vector3.Lerp(startPosition,endPosition,travelPercent);
               yield return new WaitForEndOfFrame();
           }
        }
    }
}
