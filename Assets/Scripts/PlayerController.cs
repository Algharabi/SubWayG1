using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public Player MyPlayer { get; set; }

    private Rigidbody rg;
    public float speed = 10.0F;
    public float jumpspeed = 10.0F;

    

       
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
        rg = GetComponent<Rigidbody>();
    }


    void Update()

        {
           
        }
    public void Jump()
    {
        MyPlayer.transform.Translate(1, 0, 0);
    }
    public void Crawl()
    {
        MyPlayer.transform.Translate(1, 0, 0);
    }
    public void MoveRight()
    {
        MyPlayer.transform.Translate(1, 0, 0);
    }
    public void MoveLeft()
    {
        MyPlayer.transform.Translate(1, 0, 0);
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




}