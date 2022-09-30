/*
Rosas Castillo Gabriela
Creación de videojuegos
Lección1_Challenge 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDog : MonoBehaviour
{
    float limite = 23;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -limite){
            Destroy(gameObject);    // Se destruye el proyecto
        }
        transform.Translate(Vector3.forward*Time.deltaTime*15);
    }
}
