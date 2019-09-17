using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunflower : MonoBehaviour
{

    //el tiempo que hace falta para que se recargue el disparo
    public float reloadTime;
    // tiempo restante 
    public float currentCDTime;
    // variable que nos indica si se esta ejecutando la animacion de generar
    public bool isGenerating;
    //PRefab de sun para generarlo con instanciate
    public GameObject prefabSun;
    // referencia del Animador
    public Animator myAnimator;

    void Start()
  {
        currentCDTime = 0;
        isGenerating = false;
  }

  void Update()
  {
        //si no estamos disparando , seguimos sumando tiempo
        if (isGenerating == false)
        {
            //sumamos el tiempo desde el ultimo frame
            currentCDTime += Time.deltaTime;
            //si el tiempo que ha pasado es mayor que el de recarga significa que
            // ya hemos recargado
            if(currentCDTime >= reloadTime)
            {

                // empezamos a generar el sol
                isGenerating = true;
                StartGenerateAnimation();
            }
        }
  }

  public void StartGenerateAnimation()
  {
        myAnimator.SetTrigger("Generate");

  }

  public void GenerateSun()
  {

        GameObject createdPea = Instantiate(prefabSun);

        currentCDTime = 0;
        isGenerating = false;

    }
}
