/*
Rosas Castillo Gabriela
Creación de videojuegos
Lección1_Challenge 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBone : MonoBehaviour
{
    public float distance = 21;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el hueso
        if(transform.position.z > distance){
            Destroy(gameObject);    // Se destruye el proyecto
        }
        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
