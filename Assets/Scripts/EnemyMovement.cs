using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<TileWaypoints> waypointPath = new List<TileWaypoints>();
    void Start()
    {
        PrintWaypoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintWaypoints()
    {
        foreach (TileWaypoints tilewaypoint in waypointPath)
        {
            Debug.Log(tilewaypoint.name);
        }
    }
}
