using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movmentScript : MonoBehaviour
{
     public Text score;
    int totalscore=0;
    Transform myRB;
    // public Transform plane;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score " + totalscore;
        score.color = Color.blue;
        myRB = GetComponent<Transform>();
        // plane = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10f);
        //plane.position = new Vector3(plane.position.x, plane.position.y, plane.position.z - 0.1f);
        myRB.position = new Vector3(myRB.position.x, myRB.position.y, myRB.position.z+ 0.5f);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRB.position = new Vector3(myRB.position.x - 0.1f, myRB.position.y, myRB.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRB.position = new Vector3(myRB.position.x + 0.1f, myRB.position.y, myRB.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="coins")
        {
            Destroy(other.gameObject);
            totalscore++;
            score.text = "Score " + totalscore;
        }
    }
}
