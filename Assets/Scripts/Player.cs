using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject MyPlayer;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerController.Instance.MyPlayer == null)
            PlayerController.Instance.MyPlayer = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //hit object and died
        //playercontroller.instance.player = null
        //destory(gameobject)
        
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}