using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peashooter : MonoBehaviour
{
    //el tiempo que hace falta para que se recargue el disparo
    public float reloadTime;
    // tiempo restante 
    public float currentCDTime;
    // variable para saber si esta disparando la animacion
    public bool isShooting;


    public Animator myAnimator;
  void Start()
  {

        currentCDTime = 0;
        isShooting = false;
  }

  void Update()
  {    // si no esta disparando en este momento
        if(isShooting == false)
        {

            /*
             * Cada vez que se actualice la pantalla y no este disparando
             * sumamos el tiempo de refresco entre una pantalla y otra 
             * y asi calculamos el tiempo que va transcurriendo para hacer el reload
             */
            currentCDTime = currentCDTime + Time.deltaTime;
            //Si se ha terminado de recargar , se dispara de nuevo
            if(currentCDTime >= reloadTime)
            {
                isShooting = true;
                StartShootAnimation();
            }

        }

  }

  public void StartShootAnimation()
  {
        Debug.Log("Empezando a disparar");
        myAnimator.SetTrigger("shoot"); 
  }

  public void Shoot()
  {
        Debug.Log("Disparando");

        currentCDTime = 0;
        isShooting = false;
        
  }
}
