using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas : MonoBehaviour
{
    [SerializeField]
    GameObject canvas;

    public void Show()
    {
        canvas.SetActive(!canvas.active);
    }
}
