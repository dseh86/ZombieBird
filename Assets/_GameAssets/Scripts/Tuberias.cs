using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tuberias : MonoBehaviour
{

    [SerializeField]  private int speed = 8;

     

    // Use this for initialization
    void Start()
    {
        Debug.Log("Iniciando");
        float factorposicion = Random.Range(-2,5);
        this.transform.position = new Vector3(transform.position.x, transform.position.y + factorposicion, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        //Comprobamos si estamos en estado jugando 
        if (GameConfig.IsPlaying())
        
        transform.Translate(Vector3.left * Time.deltaTime * speed);
       if (transform.position.x <-10)
        {

            Destroy(this.gameObject);
        }
        



    }
    void GetSpeed()
    {

    }
}
