/*
Rosas Castillo Gabriela
Creación de videojuegos 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject proyectilBone;
    float horInput;
    float limiteMov = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Limita el campo de movimineto del Player
        if(transform.position.x > limiteMov){ //Derecha
            transform.position = new Vector3(limiteMov, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -limiteMov){  //Izquierda
            transform.position = new Vector3(-limiteMov, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)){ //Crea un hueso en la posision del Player
            Instantiate(proyectilBone, transform.position, proyectilBone.transform.rotation);
        }

        // Movimientos del Player
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}
