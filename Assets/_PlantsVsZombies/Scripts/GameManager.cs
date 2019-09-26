using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public static GameManager Instance
    {
        get
        {
            return ((GameManager)mInstance);
        }
        set
        {
            mInstance = value;
        }
    }

    public AudioClip music;

    public int sunsCount;
    void Start()
    {

        GameUi.Instance.UpdateSuns(sunsCount);
        SoundManager.Instance.StartPlay(music);
    }

    public void AddSun(int sun)
    {
        sunsCount = sunsCount + sun;
        //Actualizar interfaz
        GameUi.Instance.UpdateSuns(sunsCount);

    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
