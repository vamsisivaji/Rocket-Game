using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ast : MonoBehaviour
{
   float min1;
   float max1;

    // Use this for initialization
    void Start()
    {

        min1 = transform.position.x;
        max1 = transform.position.x + 10;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max1 - min1) + min1, transform.position.y, transform.position.z);

    }

}
