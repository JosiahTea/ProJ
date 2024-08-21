using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    private int _progressCompleted;

    public void AddProgress()
    {
        _progressCompleted++;

        if(_progressCompleted == 5)
        {
            //Ui.LoadEndBar();
        }
    }
}
