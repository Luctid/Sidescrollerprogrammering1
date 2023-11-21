using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public PlayerDataScript SaveFile = null;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var PlayerScript = collision.gameObject.GetComponent<PhysicCharacterController>();
        if (PlayerScript != null)
        {
            SaveFile.PlayerPoints += 1;
            GameObject.Destroy(gameObject);
        }
    }
}
