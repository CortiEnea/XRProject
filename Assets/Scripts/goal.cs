using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("PortaRosso"))
        {
            scoreManager.ScoreBlu++;
            col.gameObject.GetComponent<AudioSource>().Play();  

        }

        if (col.gameObject.CompareTag("PortaBlu"))
        {
            scoreManager.ScoreRosso++;
            col.gameObject.GetComponent<AudioSource>().Play();

        }

    }
}
