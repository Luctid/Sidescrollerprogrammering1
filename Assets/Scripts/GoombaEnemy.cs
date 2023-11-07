using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaEnemy : MonoBehaviour
{

    public Rigidbody2D myRigiBody = null;

    public float MovmentSpeedPerSecond = 10.0f;
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        Vector3 characterVelocity = myRigiBody.velocity;

        characterVelocity.x = 0;

        characterVelocity += MovmentSpeedPerSecond * transform.right.normalized;

        myRigiBody.velocity = characterVelocity;

    }
}
