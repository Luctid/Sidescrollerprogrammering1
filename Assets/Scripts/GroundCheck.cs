using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PhysicCharacterController mycharacterController = null;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        mycharacterController.JumpingState = CharacterState.Grounded;
    }
}
