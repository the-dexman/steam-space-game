using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlacedObjectController : MonoBehaviour
{
    public bool isPlaced = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaced == false)
        {
            Ray placeRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit mousePoint;
            Physics.Raycast(placeRay.origin, placeRay.direction, out mousePoint);
            gameObject.transform.position = new Vector3(Mathf.Round(mousePoint.point.x), 3, Mathf.Round(mousePoint.point.z));

            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0) && Physics.CheckSphere(gameObject.transform.position, 1, 6) == false)
                {
                    isPlaced = true;
                    gameObject.layer = 7;
                }
                else if (Input.GetKeyDown(KeyCode.E))
                {
                    RotateObject(-90);
                }
                else if (Input.GetKeyDown(KeyCode.Q))
                {
                    RotateObject(90);
                }
                else
                {
                    Destroy(gameObject);
                }
            }

             
        }
        
       



    }
    void RotateObject(int turnDegrees)
    {
        gameObject.transform.Rotate(0, 0, turnDegrees);
    }
    
}
