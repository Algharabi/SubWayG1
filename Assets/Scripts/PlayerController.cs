﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public Player MyPlayer { get; set; }
    private float JumpSpeed = 15;

    private Rigidbody rg;
    public float HorVil = 0F;
    Animator anim;
    
    //public Player Player2 { get; set; }

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        rg = MyPlayer.GetComponent<Rigidbody>();
        anim = MyPlayer.GetComponent<Animator>();
        rg.velocity = new Vector3((HorVil * Time.deltaTime), 0, (4 * Time.deltaTime));

    }


    void Update()

    {


    }
    public void Jump()
    {

       rg.AddForce(Vector3.up * JumpSpeed * Time.deltaTime);
       anim.SetTrigger("Jump");
    }
    public void Crawl()
    {
        //MyPlayer.transform.Translate(1, 0, 0);
        anim.SetTrigger("Duck");
    }
    public void MoveRight()
    {
        HorVil = 3;
        StartCoroutine(returnStraight());
        anim.SetTrigger("MoveRight");
    }
    public void MoveLeft()
    {
        HorVil = -3;
        StartCoroutine(returnStraight());
        anim.SetTrigger("MoveLeft");
    }

    IEnumerator returnStraight()
    {
        yield return new WaitForSeconds(0.3f);
        HorVil = 0;
    }
}
    



        //private void OnCollisionEnter(Collision collision)
        //{
        //    //hit object and died
        //    //playercontroller.instance.player = null
        //    //destory(gameobject)
        //}

        //private void OnTriggerEnter(Collider other)
        //{

        //}





        //float translation = Input.GetAxis("Vertical") * speed;
        //    float straffe = Input.GetAxis("Horizontal") * speed;
        //    translation *= Time.deltaTime;
        //    straffe *= Time.deltaTime;

        //    transform.Translate(straffe, 0, translation);

        //    if (Input.GetKey(KeyCode.Space))
        //    {
        //        Vector3 atas = new Vector3(0, 100, 0);
        //        rg.AddForce(atas * speed, ForceMode.Impulse);
        //    }

        //    if (Input.GetKeyDown("escape"))
        //        Cursor.lockState = CursorLockMode.None;
