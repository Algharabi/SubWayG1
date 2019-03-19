using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public GameObject stone1;
    public GameObject stone2;
    public GameObject buf;
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
                posi = 11;
            else if (random2 == 2)
                posi = 0;
            else if (random2 == 3)
                posi = -11;
            if (random == 1)
            {
                Instantiate(stone1, new Vector3(posi, 2f, player.position.z + Random.Range(200, 150)),
                        buf.transform.rotation);
            }
            if (random == 2)
            {
                Instantiate(stone2, new Vector3(posi, 2f, player.position.z + Random.Range(200, 150)),
                        buf.transform.rotation);
            }
            if (random == 3)
            {
                Instantiate(buf, new Vector3(posi, 2f, player.position.z + Random.Range(200, 150)),
                        buf.transform.rotation);
            }
            timer = 1;


        }
    }
}
