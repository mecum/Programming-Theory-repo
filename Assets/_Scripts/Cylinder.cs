using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    // This class delites itself and prints different message    

    public override void OnMouseDown()
    {
        messageText.color = Color.black;
        messageText.text = "There never was any " + GetMyName(); 
        Destroy(gameObject);
    }
}
