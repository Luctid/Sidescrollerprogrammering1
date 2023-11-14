using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

   public  GoombaEnemy myEnemyScript = null;
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Vector3 enemySclae = myEnemyScript.transform.localScale;
        enemySclae.x = -enemySclae.x;
        myEnemyScript.transform.localScale = enemySclae;
        myEnemyScript.MovmentSign *= -1;
    }

}
    

   
