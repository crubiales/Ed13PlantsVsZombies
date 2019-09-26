using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    /// <summary>
    /// Metodo de carga del nuevo nivel
    /// </summary>
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }




    /// <summary>
    /// Metodo para salir de la aplicacion
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
