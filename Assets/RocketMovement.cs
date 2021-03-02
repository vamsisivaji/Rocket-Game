using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RocketMovement : MonoBehaviour
{
    Rigidbody rg;
    public Text txt;
    [SerializeField]
    float thrusht;
    [SerializeField]
    float rotateThrush;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        txt.text = "rocket game";
    }
    private void Update()
    {
        RocketFly();
        Rocketcontrols();
    }
    private void RocketFly()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rg.AddRelativeForce(Vector3.up * thrusht);
        }
    }
    private void Rocketcontrols()
    {
        rg.freezeRotation = true;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotateThrush * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * rotateThrush * Time.deltaTime);
        }
        rg.freezeRotation = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="unsafe land")
        {
            Destroy(gameObject);
            txt.text = "Game Over";
            SceneManager.LoadScene(0);
        }
        else if(collision.gameObject.tag=="end goal")
        {
            txt.text = "Completed";
            SceneManager.LoadScene(1);
        }
    }
    // Update is called once per frame
    
}
