using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Final Exam #2
 * Make this script inherit the PickUp Class.
 * Attach this script to the 3 colored cars in the middle of the map
 * Override the Activate() method to make the player car permanently change 
 * sprites to match the one on the pickup.
 * 
 * 
 * Note: The sprites you should use are located in Assets --> Sprites --> Cars
 */


public class ColorPickUp : PickUp
{
    public Sprite newCarColorSprite;
    public override void Activate()
    {
        base.Activate();
    }



}
