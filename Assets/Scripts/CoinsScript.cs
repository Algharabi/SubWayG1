using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsScript : MonoBehaviour
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
        if (pp.myScore > 100)
            speedobj = 2;
        else if (pp.myScore > 200)
            speedobj = 3;
        else if (pp.myScore > 300)
            speedobj = 4;
        else if (pp.myScore > 500)
            speedobj = 5;

        transform.Translate(Vector3.forward * Time.deltaTime * -50 * speedobj);
       
        Invoke("DestroyBullet", 40);
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    { 
    //        Destroy(gameObject);

    //    }
    //}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject. tag == "Player")
    //    {
    //        Destroy(gameObject);

    //    }
    //}
}
