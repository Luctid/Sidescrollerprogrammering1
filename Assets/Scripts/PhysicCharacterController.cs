using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicCharacterController : MonoBehaviour
{

    public SpriteRenderer mySpriteRenderer = null;
    public List<Sprite> CharacterSprites = new List<Sprite>();
    public Rigidbody2D myRigiBody = null;


    public CharacterState JumpingState = CharacterState.Airborne;


    //Gravity
    public float GravityPerSecond = 160.0f;
    public float GroundLevel = 0.0f;


    //Jump
    public float JumpSpeedFactor = 3.0f;
    public float JumpMaxHeight = 150.0f;
    public float JumpHeightDelta = 0.0f;


    //Movment
    public float MovmentSpeedPerSecond = 10.0f;

    //Player Health
    public int HP = 0;

    

    private void Update()
    {
        int hpCopy = HP-1;
        if (hpCopy < 0)
        {
            hpCopy = 0;
        }
        if (hpCopy >= CharacterSprites.Count)
        {
            hpCopy = CharacterSprites.Count - 1;
        }


        mySpriteRenderer.sprite = CharacterSprites[hpCopy];
        
        if (Input.GetKeyDown(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {
            JumpingState = CharacterState.Jumping; //Set character to jumping
            JumpHeightDelta = 0.0f; //Restart Counting Jumpdistance

        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 characterVelocity = myRigiBody.velocity;
        characterVelocity.x = 0.0f;



        //Up
        if (Input.GetKey(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {
            JumpingState = CharacterState.Jumping;
            JumpHeightDelta = 0.0f;

        }
        if (JumpingState == CharacterState.Jumping)
        {
            float jumpMovment = MovmentSpeedPerSecond * JumpSpeedFactor;
            characterVelocity.y = jumpMovment;

            JumpHeightDelta += jumpMovment * Time.deltaTime;
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




