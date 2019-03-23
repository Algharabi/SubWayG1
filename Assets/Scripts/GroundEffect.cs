using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEffect : MonoBehaviour
{
    public Renderer gr;
    public Material ground;
    float move = 0;
    float Timercreate = 2f;
    public GameObject[] blocks;
    int random;
    //float groundTimer = 3f;

    //to increase the speed after limit time 

   private float timeLimit = 10f;
    //float moveSpeed = 15f;


    // Start is called before the first frame update
    void Start()
    {
        gr = GetComponent<Renderer>();
        ground = gr.material;
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

        Timercreate -= Time.deltaTime;

        if (Timercreate <=0)
        {
            Timercreate = 4f;

            random = Random.Range(1, 3);
            GameObject obj1 = blocks[random];
            random = Random.Range(1, 3);
            GameObject obj2 = blocks[random];

            int f1 = Random.Range(1, 4);
            int f2 = Random.Range(1, 4);
            int f3=0;

            while (f1 == f2)
            {
                f2 = Random.Range(1, 3);
            }

            if ((f1 == 1 && f2 ==2) || (f1 == 2 && f2 == 1))
            {
                f3 = 3;

            } else if ((f1 == 1 && f2 == 3) || (f1 == 3 && f2 == 1))
            {
                f3 = 2;
            }
            else if ((f1 == 2 && f2 == 3) || (f1 == 3 && f2 == 2))
            {
                f3 = 1;
            }

            /////////////////////////////////////////////////////////////
            
            if (f1==1)
            {
                f1 = -9;
            } else if (f1 ==2)
            {
                f1 = 0;
            }
            else if (f1 == 3)
            {
                f1 = 9;
            }

            //////////////////////////////////
            

            if (f2 == 1)
            {
                f2 = -9;
            }
            else if (f2 == 2)
            {
                f2 = 0;
            }
            else if (f2 == 3)
            {
                f2 = 9;
            }
            ////////////////////////////////////////
            
            if (f3 == 1)
            {
                f3 = -9;
            }
            else if (f3 == 2)
            {
                f3 = 0;
            }
            else if (f3 == 3)
            {
                f3 = 9;
            }

           // Instantiate(blocks[0], new Vector3(f1, 3, 40),Quaternion.identity);
            //Instantiate(obj1, new Vector3(f2, 3, 40),Quaternion.identity);
            //Instantiate(obj2, new Vector3(f3, 3, 40),Quaternion.identity);
            
        }


    }
}
