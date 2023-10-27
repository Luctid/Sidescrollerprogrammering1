using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Block : MonoBehaviour
{


    //x = Width , y = Height
    public Vector2 Dimensions = new Vector2(16.0f, 16.0f);
    public Vector2 LowerLeftCorner = new Vector2();
    public static bool CheckCollision(Block aObject, Block aObject2)
    {
        if (aObject.LowerLeftCorner.x < aObject2.LowerLeftCorner.x+ aObject2.Dimensions.x &&
           aObject.LowerLeftCorner.x + aObject2.LowerLeftCorner.x > aObject2.Dimensions.x &&
           aObject.LowerLeftCorner.y < aObject2.LowerLeftCorner.y + aObject2.Dimensions.y &&
           aObject.LowerLeftCorner.y + aObject2.LowerLeftCorner.y < aObject2.LowerLeftCorner.y )


        
        {
            return true;
        }
        return false;
    }
    
    
    void Update()
    {
        LowerLeftCorner = new Vector2(transform.position.x - (Dimensions.x * 0.5f), 
        transform.position.y - (Dimensions.y * 0.5f));
    }
}
