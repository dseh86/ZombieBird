using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {

    [SerializeField] Transform prefabTuberia;
    
    [SerializeField] float ratioGeneracionTuberias;


	// Use this for initialization
	void Start () {
        InvokeRepeating("GeneratePipe", 0, ratioGeneracionTuberias);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GeneratePipe() {
        if (GameConfig.IsPlaying()) { 
        Debug.Log("Generando Tubería");
        //Instanciamos el objeto tuberia
        Instantiate(prefabTuberia, transform.position, Quaternion.identity);
        }
    }

}
