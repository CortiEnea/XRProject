using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    void Start()
    {
        text.SetText("Best Score: " + PlayerPrefs.GetInt("BestScore"));
    }

}
