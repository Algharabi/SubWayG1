using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinR : MonoBehaviour
{
    Transform coin;
    // Start is called before the first frame update
    void Start()
    {
       
        coin = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        coin.Rotate(Vector3.up, 100 * Time.deltaTime);
    }
}
