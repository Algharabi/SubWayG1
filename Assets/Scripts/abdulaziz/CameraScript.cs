using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 target = Player.position + Player.TransformDirection(Offset);
        Vector3 TargetVector = target - transform.position;
        transform.LookAt(Player.position + Player.forward);
        transform.position += TargetVector.normalized * speed * Time.deltaTime * Mathf.Min(3, TargetVector.magnitude);
    }
}
