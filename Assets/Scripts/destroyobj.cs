using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobj : MonoBehaviour
{

    public float timer = 15f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * -15);

        if (timer <=0)
        {
            deleteobject();
        }


    }


    void deleteobject()
    {
        Destroy(this.gameObject);
    }
}
