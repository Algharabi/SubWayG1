using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    bool IsplayerMove = true;
    public GameObject PuseMenu;
    public string PlayerState ;
    // Start is called before the first frame update
    void Start()
    {
        PuseMenu.SetActive(false);
        PlayerState = "Mid";
    }

    // Update is called once per frame
    void Update()
    {

        if (IsplayerMove)
        {
            transform.Translate(Vector3.forward* Time.deltaTime * 10);


            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (PlayerState == "Mid")
                {
                    PlayerState = "left";
                    this.transform.position = new Vector3(-7.5f, transform.position.y,transform.position.z);
                }
                else if (PlayerState == "right")
                {
                    PlayerState = "Mid";
                    this.transform.position = new Vector3(0f, transform.position.y, transform.position.z);
                }
                else
                {
                    print("The Player is In left Now");
                }

            }




            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (PlayerState == "Mid")
                {
                    PlayerState = "right";
                    this.transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
                }
                else if (PlayerState == "left")
                {
                    PlayerState = "Mid";
                    this.transform.position = new Vector3(0f, transform.position.y, transform.position.z);
                }
                else
                {
                    print("The Player is In right Now");
                }

            }





        }
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coins")
        {
            print("takecoins");
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Block")
        {
            IsplayerMove = false;
            PuseMenu.SetActive(true);
        }
    }




}
