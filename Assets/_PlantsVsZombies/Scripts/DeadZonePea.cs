﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZonePea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag( "Projectile"))
        {
            Destroy(collision.gameObject);
        }
    }


}
