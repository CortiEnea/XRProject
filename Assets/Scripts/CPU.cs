using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CPUController : MonoBehaviour
{
    public GameObject slider;
    public float velocitaMovimento = 5f;

    public Transform disco; 
    public Transform campo; 

    private float limiteSinistro;
    private float limiteDestro;

    private void Start()
    {
        if (campo != null)
        {
            limiteSinistro = -2; 
            limiteDestro = 3;
        }
       
    }

    private void Update()
    {
        float posizioneDiscoX = disco.position.x;

        if (transform.position.x < posizioneDiscoX)
        {
            float nuovaPosizioneX = Mathf.MoveTowards(transform.position.x, posizioneDiscoX, velocitaMovimento * Time.deltaTime);
            transform.position = new Vector3(nuovaPosizioneX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > posizioneDiscoX)
        {
            float nuovaPosizioneX = Mathf.MoveTowards(transform.position.x, posizioneDiscoX, velocitaMovimento * Time.deltaTime);
            transform.position = new Vector3(nuovaPosizioneX, transform.position.y, transform.position.z);
        }

        float posizioneClampedX = Mathf.Clamp(transform.position.x, limiteSinistro, limiteDestro);
        transform.position = new Vector3(posizioneClampedX, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("disco"))
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1f, 0), ForceMode.Impulse);

        }


    }

    public void changeSpeed()
    {
        velocitaMovimento = slider.GetComponent<Slider>().value;
            
    }
}
