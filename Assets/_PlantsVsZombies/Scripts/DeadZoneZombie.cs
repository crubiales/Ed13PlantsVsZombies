using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneZombie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag( "Zombie"))
        {
            GameManager.Instance.GameOver();
        }
    }


}
