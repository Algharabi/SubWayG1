using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCupe : MonoBehaviour
{
    public float speedobj = 1;
    public Player pp;
    // Start is called before the first frame update
    void Start()
    {
        pp = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(gameObject.transform.position.z<)
        if (pp.myScore > 100)
            speedobj = 2;
        else if (pp.myScore > 200)
            speedobj = 3;
        else if (pp.myScore > 300)
            speedobj = 4;
        else if (pp.myScore > 500)
            speedobj = 5;
       
        transform.Translate(Vector3.forward * Time.deltaTime * -50 * speedobj);
        Invoke("DestroyBullet", 20);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
