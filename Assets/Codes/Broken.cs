﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "LeaderBall")
        {
            Destroy (gameObject, 0.2f);
        }
    }
}
