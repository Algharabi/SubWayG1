using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    private GameObject cube1;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject buf;
    public GameObject coins;
    Transform player;
    float timer = 1;
    int random, random2;
    float posi;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 0.01f;
       
        if (timer <= 0)
        {
            random = Random.Range(1, 4);
            random2 = Random.Range(1, 4);
            if (random2 == 1)
                posi = 10;
            else if (random2 == 2)
                posi = 0;
            else if (random2 == 3)
                posi = -10;
            if (random == 1)
            {
                cube1= Instantiate(stone1, new Vector3(posi, 1f, player.position.z + Random.Range(200, 150)),
                        buf.transform.rotation);
                Instantiate(coins, new Vector3(posi, 5.5f,  cube1.transform.position.z-2),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 5.5f, cube1.transform.position.z+2),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 5.5f, cube1.transform.position.z+6),
                        coins.transform.rotation);
                
            }
            if (random == 2)
            {
                cube1 = Instantiate(stone2, new Vector3(posi, 1f, player.position.z + Random.Range(200, 150)),
                        buf.transform.rotation);
                Instantiate(coins, new Vector3(posi, 5.5f, cube1.transform.position.z - 2),
                         coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 5.5f, cube1.transform.position.z + 2),
                        coins.transform.rotation);
                Instantiate(coins, new Vector3(posi, 5.5f, cube1.transform.position.z + 6),
                        coins.transform.rotation);
            }
            if (random == 3)
            {
                cube1 = Instantiate(buf, new Vector3(posi, 4f, player.position.z + Random.Range(200, 150)),
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
