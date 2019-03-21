using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsScript : MonoBehaviour
{
   
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -50);
       
        Invoke("DestroyBullet", 40);
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            Destroy(gameObject);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject. tag == "Player")
        {
            Destroy(gameObject);

        }
    }
}
