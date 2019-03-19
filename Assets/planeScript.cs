using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour
{
    Transform myRB;
    // public Transform plane;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Transform>();
        // plane = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //plane.position = new Vector3(plane.position.x, plane.position.y, plane.position.z - 0.1f);
        myRB.position = new Vector3(myRB.position.x, myRB.position.y, myRB.position.z - 0.1f);
       
    }
}
