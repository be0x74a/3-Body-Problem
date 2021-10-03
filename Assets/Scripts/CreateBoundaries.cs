using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoundaries : MonoBehaviour
{

    public GameObject objBoundaryTopRightCorner;
    public GameObject objBoundaryBottomLeftCorner;


    // Start is called before the first frame update
    void Start()
    {
        SetupBoundaries();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupBoundaries()
    {
        Vector3 point = new Vector3();

        point = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.nearClipPlane));
        objBoundaryTopRightCorner.transform.position = point;

        point = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        objBoundaryBottomLeftCorner.transform.position = point;
    }
}
