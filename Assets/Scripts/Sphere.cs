using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sphere : Shape
{
    //Polymorphism
    public override void Greet()
    {
        SetTextColor();
        text.text = "Get off!";
    }
}
