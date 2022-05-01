using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[ExecuteAlways]
public class CoordinateLabler : MonoBehaviour
{
    TextMeshPro  label;
    Vector2Int  coordinates = new Vector2Int();
    void Awake()
     {
        label = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying)
         {

             DisplayCoordinates();
            UpdateObjectName();
        }
    }

    void UpdateObjectName(){

        transform.parent.name = coordinates.ToString();

    }

    void DisplayCoordinates(){

        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x); 
        coordinates.y = Mathf.RoundToInt(transform.parent.position.y / UnityEditor.EditorSnapSettings.move.x);
        label.text = coordinates.x + "," + coordinates.y;

    }
}
