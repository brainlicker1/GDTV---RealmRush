using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<TileWaypoints> waypointPath = new List<TileWaypoints>();
    [SerializeField] float enemyMoveSpeed = 1f;

    void Start()
    {
       StartCoroutine(PrintWaypoints());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PrintWaypoints()
    {   
        foreach (TileWaypoints tilewaypoint in waypointPath)
        {   
            transform.position = tilewaypoint.transform.position;
            yield return new WaitForSeconds(enemyMoveSpeed);
        }
    }
}
