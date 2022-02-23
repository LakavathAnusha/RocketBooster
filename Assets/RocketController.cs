using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField]
    private float roketRotationSpeed;
    [SerializeField]
    private float rocketThrustSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        
    }

    private void MoveRocketUp()
    {
        RocketThrust();
        RocketRotate();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //string sceneName = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(sceneName);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void RocketRotate()
    {
        //rb.freezeRotation = false;
        float speed = 100f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            roketRotationSpeed = speed * Time.deltaTime;
            transform.Rotate(Vector3.back*roketRotationSpeed);
            Debug.Log("backword roation");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            roketRotationSpeed =speed * Time.deltaTime;
            transform.Rotate(Vector3.forward*roketRotationSpeed);
            Debug.Log("forword roation");
        }
    }

    private void RocketThrust()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float thrust = 100f;
            rocketThrustSpeed = thrust * Time.deltaTime;
            rb.AddRelativeForce(Vector3.up*rocketThrustSpeed);
            Debug.Log("Going Up");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        MoveRocketUp();
    }
}
