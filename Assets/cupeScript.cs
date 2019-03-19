using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupeScript : MonoBehaviour
{
    public GameObject cupe;
    Transform player;
    float timer = 1;
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
            Instantiate(cupe, new Vector3(Random.Range(4.5f, -4.5f), 1.5f, player.position.z - Random.Range(150,200)),
                    cupe.transform.rotation);
            timer = 1;
            
        }
    }
}
