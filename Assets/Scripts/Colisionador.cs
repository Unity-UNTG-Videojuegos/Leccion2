/*
Rosas Castillo Gabriela
Creación de videojuegos
Lección1_Challenge 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {    
        Destroy(gameObject); //Destruye el objeto
    }
}
