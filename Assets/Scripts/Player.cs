using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool IsplayerMove = true;
    public GameObject PuseMenu;
    public string PlayerState;
    //public GameObject MyPlayer;

    private void Awake()
    {
        if (PlayerController.Instance.MyPlayer == null)
            PlayerController.Instance.MyPlayer = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Block")
        {
            IsplayerMove = false;
            PuseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="coins")
        {
            Destroy(other.gameObject);
        }
    }
}