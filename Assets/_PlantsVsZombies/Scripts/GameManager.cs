using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Update()
    {   
        
    }

    public void AddSun(int sun)
    {
        sunsCount = sunsCount + sun;
        //Actualizar interfaz
        GameUi.Instance.UpdateSuns(sunsCount);




    }
}
