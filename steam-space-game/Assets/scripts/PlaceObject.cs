using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public GameObject conveyorObject;
    public KeyCode conveyorKey;
    public Camera mainCamera;
    public bool isPlacing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray placeRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit mousePoint;
        Physics.Raycast(placeRay.origin, placeRay.direction, out mousePoint);

        if (Input.GetKeyDown(conveyorKey))
        {
            Instantiate(conveyorObject, new Vector3(Mathf.Round(mousePoint.point.x), 1, Mathf.Round(mousePoint.point.z)), conveyorObject.transform.rotation);
        }
    }
}
