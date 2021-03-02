using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidmovement : MonoBehaviour
{
     public float min;
     public float max;

    // Use this for initialization
    void Start()
    {

        min = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.z);

    }

}
