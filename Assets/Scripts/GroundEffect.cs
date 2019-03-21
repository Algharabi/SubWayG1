using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEffect : MonoBehaviour
{

    public Renderer gr;
    public Material ground;
    float move = 0;
    //float Timercreate = 2f;
    //public GameObject[] blocks;
    //int random;
    // public GameObject coins;
    private GameObject cube1;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject buf;
    public GameObject coins;
    public Transform player;
    float timer = 1;
    int random, random2;
    float posi;
    //float groundTimer = 3f;

    //to increase the speed after limit time 

    private float timeLimit = 10f;
    //float moveSpeed = 15f;


    // Start is called before the first frame update
    void Start()
    {
        gr = GetComponent<Renderer>();
        ground = gr.material;
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        move += Time.deltaTime * -3;
        gr.material.SetTextureOffset("_MainTex", new Vector2(0, move));

        //to increase the speed after limit time 

        //for (int i = 0; i <= timeLimit; i++)
        //{


        //    groundTimer++;
        //        //  timeLimit += 5f;

        //}
        ////////////////////////////////////////////////////
        //now work for creating objects

        //Timercreate -= Time.deltaTime;

        //if (Timercreate <=0)
        //{
        //    Timercreate = 4f;

        //    random = Random.Range(1, 3);
        //    GameObject obj1 = blocks[random];
        //    random = Random.Range(1, 3);
        //    GameObject obj2 = blocks[random];

        //    int f1 = Random.Range(1, 4);
        //    int f2 = Random.Range(1, 4);
        //    int f3=0;

        //    while (f1 == f2)
        //    {
        //        f2 = Random.Range(1, 3);
        //    }

        //    if ((f1 == 1 && f2 ==2) || (f1 == 2 && f2 == 1))
        //    {
        //        f3 = 3;

        //    } else if ((f1 == 1 && f2 == 3) || (f1 == 3 && f2 == 1))
        //    {
        //        f3 = 2;
        //    }
        //    else if ((f1 == 2 && f2 == 3) || (f1 == 3 && f2 == 2))
        //    {
        //        f3 = 1;
        //    }

        //    /////////////////////////////////////////////////////////////

        //    if (f1==1)
        //    {
        //        f1 = -9;
        //    } else if (f1 ==2)
        //    {
        //        f1 = 0;
        //    }
        //    else if (f1 == 3)
        //    {
        //        f1 = 9;
        //    }

        //    //////////////////////////////////


        //    if (f2 == 1)
        //    {
        //        f2 = -9;
        //    }
        //    else if (f2 == 2)
        //    {
        //        f2 = 0;
        //    }
        //    else if (f2 == 3)
        //    {
        //        f2 = 9;
        //    }
        //    ////////////////////////////////////////

        //    if (f3 == 1)
        //    {
        //        f3 = -9;
        //    }
        //    else if (f3 == 2)
        //    {
        //        f3 = 0;
        //    }
        //    else if (f3 == 3)
        //    {
        //        f3 = 9;
        //    }

        //    // Instantiate(blocks[0], new Vector3(f1, 3, 40),Quaternion.identity);
        //  cube1=  Instantiate(obj1, new Vector3(f2, 3, 40), Quaternion.identity);
        //    cube1 = Instantiate(obj2, new Vector3(f3, 3, 40), Quaternion.identity);
        //    Instantiate(coins, new Vector3(f2,2f, cube1.transform.position.z - 2),
        //                coins.transform.rotation);
        //    Instantiate(coins, new Vector3(f2, 2f, cube1.transform.position.z + 2),
        //            coins.transform.rotation);
        //    Instantiate(coins, new Vector3(f2, 2f, cube1.transform.position.z + 6),
        //            coins.transform.rotation);






        timer -= 0.01f;

        if (timer <= 0)
        {
            random = Random.Range(1, 4);
            random2 = Random.Range(1, 4);
            if (random2 == 1)
                posi = 8;
            else if (random2 == 2)
                posi = -1;
            else if (random2 == 3)
                posi = -10;
            if (random == 1)
            {
                cube1 = Instantiate(stone1, new Vector3(posi+1, 3f, player.position.z + Random.Range(100, 150)),
                        buf.transform.rotation);
                Instantiate(coins, new Vector3(posi, 7.5f, cube1.transform.position.z - 2),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi,7.5f, cube1.transform.position.z + 2),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 7.5f, cube1.transform.position.z + 6),
                        coins.transform.rotation);

            }
            if (random == 2)
            {
                cube1 = Instantiate(stone2, new Vector3(posi+1, 3f, player.position.z + Random.Range(100, 150)),
                        buf.transform.rotation);
                Instantiate(coins, new Vector3(posi, 7.5f, cube1.transform.position.z - 2),
                         coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 7.5f, cube1.transform.position.z + 2),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 7.5f, cube1.transform.position.z + 6),
                        coins.transform.rotation);
            }
            if (random == 3)
            {
                cube1 = Instantiate(buf, new Vector3(posi+1, 5f, player.position.z + Random.Range(100, 150)),
                        buf.transform.rotation);
                Instantiate(coins, new Vector3(posi, 2f, cube1.transform.position.z + 1),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 2f, cube1.transform.position.z + 5),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 2f, cube1.transform.position.z + 9),
                        coins.transform.rotation);
            }
            timer = 1;



        }


    }
}

