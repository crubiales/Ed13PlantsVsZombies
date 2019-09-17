using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    //velocidad del zombie
    public float speed;
    // el zombie se esta muriendo
    public bool isDead;
    //el zombie esta comiendo
    public bool isEating;

    void Start()
    {
        //inicializamos variables
        isDead = false;
        isEating = false;
    }

    void Update()
    {// si el zombi no esta muriendose ni esta comiendo
        if (isEating == false && isDead == false)
        {
            //moverse
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }

    }

    public void Die()
    {
        isDead = true;
        Destroy(this.gameObject, 0.1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Estoy chocando con ..." + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Plants"))
        {
            //isEating = true;
            Destroy(collision.gameObject);
        }


    }
}
