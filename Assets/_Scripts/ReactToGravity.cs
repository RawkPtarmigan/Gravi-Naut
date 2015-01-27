﻿using UnityEngine;
using System.Collections;

public class ReactToGravity : MonoBehaviour 
{
    void FixedUpdate()
    {
        if(this.transform.tag == "Dynamic")
            rigidbody2D.AddForce(GameData.data.gravity * GameData.data.direction);
    }
}
