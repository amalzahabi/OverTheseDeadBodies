using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal2 : MonoBehaviour
{
    Rigidbody _rigidbody;
    Transform target;
    Vector2 moveDirection;
    public float speed;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();


    }

    private void Update()
    {



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    //void OnCollisionEnter(Collision other)
    
       
    
}