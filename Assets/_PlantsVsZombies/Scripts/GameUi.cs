using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameUi : Singleton<GameUi>
{
    public static GameUi Instance
    {
        get
        {
            return ((GameUi)mInstance);
        }
        set
        {
            mInstance = value;
        }
    }

    public Text curSuns;

    public void UpdateSuns(int suns)
    {
        curSuns.text = $"{suns}";
    }


    // Start is called before the first frame update

}
