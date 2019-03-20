using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsScript : MonoBehaviour
{
   
    
    Transform coin;
    // Start is called before the first frame update
    void Start()
    {
        
        coin = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       coin.Rotate(Vector3.right, 100 * Time.deltaTime);
        Invoke("DestroyBullet", 40);
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag=="Player")
    //    {
    //        Destroy(gameObject);
           
    //    }
    //}
}
