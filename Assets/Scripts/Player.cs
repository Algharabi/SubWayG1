using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; set; }
    int Ammo;
    float damage;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerController.Instance.MyPlayer == null)
        PlayerController.Instance.MyPlayer = this;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //    transform.Translate(1, 0, 0);
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