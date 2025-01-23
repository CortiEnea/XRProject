using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ApriPorta : MonoBehaviour
{
    [SerializeField]
    private GameObject porta;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LettoreChiave"))
        {
            porta.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }
}
