using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public Player MyPlayer { get; set; }
    public float JumpHT = 10f;
    public int laneNum = 2;
    private Rigidbody rg;
    //public float HorVil = 0F;
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
        //rg.velocity = new Vector3((HorVil * Time.deltaTime), 0, (4 * Time.deltaTime));
        //rg.velocity = new Vector3((HorVil * Time.deltaTime), 0, 0);
    }


    void Update()

    {


    }
    public void Jump()
    {
        rg.AddForce(Vector3.up * JumpHT, ForceMode.Force);
        //rg.velocity = new Vector3(0, (30 * (JumpHT)), (4 * Time.deltaTime));
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
            MyPlayer.transform.position = new Vector3((MyPlayer.transform.position.x + 9f),
                MyPlayer.transform.position.y, MyPlayer.transform.position.z);
            //HorVil = (3 * Time.deltaTime);
            //StartCoroutine(returnStraight());
            anim.SetTrigger("MoveRight");
            laneNum += 1;
        }
    }
    public void MoveLeft()
    {
        if (laneNum > 1)
        {
            MyPlayer.transform.position = new Vector3((MyPlayer.transform.position.x - 9f),
                MyPlayer.transform.position.y, MyPlayer.transform.position.z);
            //HorVil = (-3 * Time.deltaTime);
            //StartCoroutine(returnStraight());
            anim.SetTrigger("MoveLeft");
            laneNum -= 1;
        }
    }

    //IEnumerator returnStraight()
    //{
    //    yield return new WaitForSeconds(0.3f);
    //    HorVil = 0;
    //}
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


