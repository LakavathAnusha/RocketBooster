using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RocketAllowed")
        {
            Debug.Log("you are allowed");
            Debug.Log("you won the game");
        }
        else if (collision.gameObject.tag == "NotAllowed")
        {
            Debug.Log("not Allowed");
        }
        
    }
}
