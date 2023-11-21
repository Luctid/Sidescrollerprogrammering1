using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    public bool IsPlayer = false;

    public int DamageValue = -1;
    public bool DeltDamageLastFrame = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (DeltDamageLastFrame == true)
        {
            DeltDamageLastFrame = false;
            return;
        }
        {
            
        }
        if (IsPlayer)
        {
            var enemyscript = collision.gameObject.GetComponent<GoombaEnemy>();
            if (enemyscript != null)
            {
                enemyscript.TakeDamage(DamageValue);
                DeltDamageLastFrame = true;
            }
        }
        else
        {

        
           var Playerscript = collision.gameObject.GetComponent<PhysicCharacterController>();
            if (Playerscript != null)
            {
                Playerscript.TakeDamage(DamageValue);
                DeltDamageLastFrame = true;
            }
        
            
        }

    }
}
