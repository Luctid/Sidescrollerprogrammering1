using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPost : MonoBehaviour
{

    public Sceneloader mySceneLoader = null;
    public string NextScene = "MainMenu";


    private void OnCollisionEnter2D(Collision2D collision)
    {
        var Playerscript = collision.gameObject.GetComponent<PhysicCharacterController>();
        if (Playerscript != null)
        {
            mySceneLoader.LoadScene(NextScene);
        }

    }

}     
          

     
    

