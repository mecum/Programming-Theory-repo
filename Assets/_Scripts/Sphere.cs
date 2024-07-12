using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // This class sets random color to the text instead of it's own    

    public override Vector4 GetMyColor()
    {
        color = Random.ColorHSV(0f, 1f);

        return color;
    }
}
