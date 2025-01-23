using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _scoreRosso;
    private int _scoreBlu;

    public GameObject txtScoreRosso;
    public GameObject txtScoreBlu;

    private int bestScore;

    public int ScoreRosso
    {
        get { return _scoreRosso; }
        set 
        { 
            _scoreRosso = value;
        }
    }


    public int ScoreBlu
    {
        get { return _scoreBlu; }
        set 
        { 
            _scoreBlu = value;
            if (_scoreBlu > PlayerPrefs.GetInt("BestScore"))
            {
                PlayerPrefs.SetInt("BestScore", _scoreBlu);
            }

        }
    }


    void Update()
    {
        txtScoreRosso.GetComponent<TextMeshProUGUI>().text = _scoreBlu.ToString() + " Rosso";
        txtScoreBlu.GetComponent<TextMeshProUGUI>().text = "Blu " + _scoreBlu.ToString();
    }
}
