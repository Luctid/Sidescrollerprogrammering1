using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float GravityPerSecond = 160.0f;
    public float GroundLevel = 0.0f;

    public float MovmentSpeedPerSecond = 10.0f;
    // Update is called once per frame
    void Update()
    {
        //gravity

        Vector3 gracityPosition = transform.position;
        gracityPosition.y -= GravityPerSecond * Time.deltaTime;
        if (gracityPosition.y < GroundLevel) { gracityPosition.y = GroundLevel; }
        transform.position = gracityPosition;


        //Up
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 characterPosition = transform.position;
            characterPosition.y += MovmentSpeedPerSecond * Time.deltaTime;
            transform.position = characterPosition;
            
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
    }
}
