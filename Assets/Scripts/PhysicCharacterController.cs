using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicCharacterController : MonoBehaviour
{
    public Rigidbody2D myRigiBody = null;

    public CharacterState JumpingState = CharacterState.Airborne;


    // Start is called before the first frame update
    void Start()
    {

    }
    //Gravity
    public float GravityPerSecond = 160.0f;
    public float GroundLevel = 0.0f;


    //Jump
    public float JumpSpeedFactor = 3.0f;
    public float JumpMaxHeight = 150.0f;
    private float JumpHeightDelta = 0.0f;

    //Movment
    public float MovmentSpeedPerSecond = 10.0f;
    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 characterVelocity = myRigiBody.velocity;
        characterVelocity.x = 0.0f;
        characterVelocity.y = 0.0f;

        if (JumpingState != CharacterState.Jumping)
        {
            JumpingState = CharacterState.Grounded;
        }

        //Up
        if (Input.GetKey(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {



            JumpingState = CharacterState.Jumping;
            JumpHeightDelta = 0.0f;
            
        }
        if (JumpingState == CharacterState.Jumping)
        {
          
            
            float totalJumpMovmentThisFrame = MovmentSpeedPerSecond * JumpSpeedFactor;
            characterVelocity.y += totalJumpMovmentThisFrame;
            
            JumpHeightDelta += totalJumpMovmentThisFrame;
            if (JumpHeightDelta >= JumpMaxHeight)
            {
                JumpingState = CharacterState.Airborne;
                JumpHeightDelta = 0.0f;
                characterVelocity.y = 0.0f;
            }
        }
        //Down


        
        //Left
        if (Input.GetKey(KeyCode.A))
        {
           
            characterVelocity.x -= MovmentSpeedPerSecond;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            characterVelocity.x += MovmentSpeedPerSecond;
        }
        myRigiBody.velocity = characterVelocity;
        

    }
}

