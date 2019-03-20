using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public Player MyPlayer { get; set; }
    private float JumpHT = 0.5f;
    public int laneNum = 2;
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
        //rg.AddForce(Vector3.up * JumpSpeed * Time.deltaTime);
        rg.velocity = new Vector3(0, (10 * (JumpHT)) , (4 * Time.deltaTime));
        anim.SetTrigger("Jump");
    }
    public void Duck()
    {
        //MyPlayer.transform.Translate(1, 0, 0);
        anim.SetTrigger("Duck");
    }
    public void MoveRight()
    {
        if (laneNum < 3)
        {
            HorVil = (3 * Time.deltaTime);
            StartCoroutine(returnStraight());
            anim.SetTrigger("MoveRight");
            laneNum += 1;
        }
    }
    public void MoveLeft()
    {
        if (laneNum > 1)
        {
            HorVil = (-3 * Time.deltaTime);
            StartCoroutine(returnStraight());
            anim.SetTrigger("MoveLeft");
            laneNum -= 1;
        }
    }

    IEnumerator returnStraight()
    {
        yield return new WaitForSeconds(0.3f);
        HorVil = 0;
    }
    public void Die()
    {
        anim.SetTrigger("Die");
    }
    public void Respawn()
    {
        anim.SetTrigger("ReSpawn");
    }
    public void RePlay()
    {
        anim.SetTrigger("RePlay");
    }

}
    

