using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public int AddHealth = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var Playerscript = collision.gameObject.GetComponent<PhysicCharacterController>();
        if(Playerscript != null) 
        {
            Playerscript.HP += AddHealth;
            AddHealth = 0;
            GameObject.Destroy(gameObject);
        }
        
    }

}
