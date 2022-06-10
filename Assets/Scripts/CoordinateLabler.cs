using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[ExecuteAlways]
public class CoordinateLabler : MonoBehaviour
{   
     [SerializeField] Color defaultColor = Color.white;
    [SerializeField] Color blockedColor = Color.gray;
    TileWaypoints waypoint;
    TextMeshPro  label;
    Vector2Int  coordinates = new Vector2Int();
    void Awake()
     {  waypoint = GetComponentInParent<TileWaypoints>();
        
        label = GetComponent<TextMeshPro>();
        label.enabled = false;
        DisplayCoordinates();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying)
         {

             DisplayCoordinates();
            UpdateObjectName();

        }
    
        ColorCoordinates();
        ToggleLabels();
    }
    void ColorCoordinates(){
        if(waypoint.IsPlaceable) {

            label.color = defaultColor;
        }
        else{
            label.color = blockedColor;
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

    void ToggleLabels(){

        if(Input.GetKeyDown(KeyCode.Backspace)){

            label.enabled = !label.IsActive();
        }

    }
}
