using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PajaroZombi : MonoBehaviour {
    //Atributos - Se asocian en el editor - como si fueran parámetros similar
    [SerializeField] Text marcadorPuntos;
    [SerializeField] int puntos = 0;
    [SerializeField] float fuerza = 10f;
    [SerializeField] ParticleSystem prefabExplosion;
    [SerializeField] AudioSource asSonidoMuerte;
    [SerializeField] AudioSource asSonidoPuntuacion;
    
    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        GameConfig.ArrancaJuego();
        rb = GetComponent<Rigidbody>();
        ActualizarMarcador();

    }

    private void ActualizarMarcador()
    {
        marcadorPuntos.text = "Score: " + puntos;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown("space"))
        {
            //Debug.Log("Pulsado espacio con fuerza " + fuerza.ToString());

            rb.AddForce(transform.up * fuerza);
          
        }
	}

    private void OnCollisionEnter(Collision collision)
    {   
        //Instanciar el sistema de párticulas sobre FrankenPajaro
        Instantiate(prefabExplosion, transform.position, Quaternion.identity);

        //Sonido cuando muere
        asSonidoMuerte.Play();

        //Desactivar el render del objeto para hacerlo invisible 
        gameObject.SetActive(false);

        GameConfig.ParaJuego();

        // Añadir un retraso para que puedan salir las párticulas antes de reiniciar 
        Invoke("FinalizarPartida", 2f);
     

    }

    private void FinalizarPartida()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        puntos++;
        asSonidoPuntuacion.Play();
        Debug.Log("Puntuación: " + puntos);
       
        ActualizarMarcador();
        
    }



}
