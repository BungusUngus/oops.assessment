using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreSaver : MonoBehaviour
{

    public HighScoreData data;

    private void Start()
    {
        data = JsonSaveLoad.LoadHighScore();
    }

    private void OnDestroy()
    {

    }
}
