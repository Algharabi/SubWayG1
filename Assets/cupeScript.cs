using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupeScript : MonoBehaviour
{
    public GameObject cupe;
    Transform player;
    float timer = 10;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 0.1f;
        if (timer <= 0)
        {
            Instantiate(cupe, new Vector3(Random.Range(7f, -6f), 1.5f, player.position.z - Random.Range(70,100)),
                    cupe.transform.rotation);
            timer = 10;
        }
    }
}
