using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCupe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if(gameObject.transform.position.z<)

        Invoke("DestroyBullet", 40);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
