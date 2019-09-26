using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{

    public Animator myAnimator;

    public float currentDestroyTime;
    public float destroyTime;

    public bool isTaken;

    public int sunValue = 10;

   
    private void Start()
    {

        isTaken = false;
        currentDestroyTime = 0;
    }

    private void Update()
    {


    }

    private void OnMouseDown()
    {
        if (isTaken == false)
        {
            isTaken = true;
            GameManager.Instance.AddSun(sunValue);
            myAnimator.SetTrigger("Taken");
            
        }
    }

    public void destroySun()
    {
        Destroy(this.gameObject, 0f);
    }

}
