using System.Collections;
using System.Collections.Generic;
using UnityEngine;










public enum CharacterState
{
   Grounded = 0, 
   Airborne = 1,
   Jumping = 2,
   Total
}
public class CharacterController : MonoBehaviour
{
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
    void Update()
    {
        bool ismoving = false;
        //gravity


        if(transform.position.y <= GroundLevel)
        {
            Vector3 characterPosition = transform.position;
            characterPosition.y = GroundLevel;
            transform.position = characterPosition;
            JumpingState = CharacterState.Grounded;
        }

        //Up
        if (Input.GetKey(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {

           
            
            JumpingState = CharacterState.Jumping;
            JumpHeightDelta = 0.0f;
            //Vector3 characterPosition = transform.position;
            //characterPosition.y += MovmentSpeedPerSecond * Time.deltaTime;
            //transform.position = characterPosition;
            //ismoving = true;
        }
        if(JumpingState == CharacterState.Jumping)
        {
            Vector3 characterPosition = transform.position;
            //float currentPosition = characterPosition.y;
            float totalJumpMovmentThisFrame = MovmentSpeedPerSecond * JumpSpeedFactor * Time.deltaTime;
            characterPosition.y += totalJumpMovmentThisFrame;
            transform.position = characterPosition;
            JumpHeightDelta += totalJumpMovmentThisFrame;
            if (JumpHeightDelta >= JumpMaxHeight)
            {
                JumpingState = CharacterState.Airborne;
                JumpHeightDelta = 0.0f;
            }
        }
        //Down
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 characterPosition = transform.position;
            characterPosition.y -= MovmentSpeedPerSecond * Time.deltaTime;
            transform.position = characterPosition;
        }
        //Left
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 characterPosition = transform.position;
            characterPosition.x -= MovmentSpeedPerSecond * Time.deltaTime;
            transform.position = characterPosition;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 characterPosition = transform.position;
            characterPosition.x += MovmentSpeedPerSecond * Time.deltaTime;
            transform.position = characterPosition;
        }
        //Gravity
        if (JumpingState == CharacterState.Airborne)
        {
            Vector3 gracityPosition = transform.position;
            gracityPosition.y -= GravityPerSecond * Time.deltaTime;
            if (gracityPosition.y < GroundLevel) { gracityPosition.y = GroundLevel; }
            transform.position = gracityPosition;


        }

    }
}
