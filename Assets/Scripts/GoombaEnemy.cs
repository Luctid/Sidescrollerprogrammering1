using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaEnemy : MonoBehaviour
{

    public int HP = 0;

    public void TakeDamage(int aHPValue)
    {
        HP += aHPValue;


        if(HP < 0 )
        {
         GameObject.Destroy( gameObject );
        }
    }


    public Rigidbody2D myRigiBody = null;

    public float MovmentSpeedPerSecond = 10.0f;
    public int MovmentSign = 1;
    

   
    void FixedUpdate()
    {
        Vector3 characterVelocity = myRigiBody.velocity;

        characterVelocity.x = 0;

        characterVelocity += MovmentSign * MovmentSpeedPerSecond * transform.right.normalized;

        myRigiBody.velocity = characterVelocity;

    }
}
