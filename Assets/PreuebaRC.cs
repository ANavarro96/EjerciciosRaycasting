using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreuebaRC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LanzarRayo();
    }


    void LanzarRayo()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;

        RaycastHit hit;

        if(Physics.Raycast(origen, direccion, out hit)){
            // Si entramos aquí, es que hemos chocado con algo!

            Debug.Log("Hemos golpeado a: " +  hit.collider.gameObject.name);
            Debug.Log("El punto en concreto es: " + hit.point);
            Debug.Log("La normal del punto al que hemos dado es... " + hit.normal);
            Debug.Log("Y hay un total de... " + hit.distance + " metros al objetivo");


        }
    }

    void LanzarRayoMascara()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = -transform.up;

        int mascara = 1 << 3 | 1 << 6;
        // El operador es el operador 'or', que crea una máscara
        // poniendo a 1 los bits 3 y 6

        // Esta función devuelve la(s) máscara(s) con los nombres en concreto
        int capaPared = LayerMask.GetMask("Suelo","Fuego");

        // Si queremos que detecten todas las capas menos unas en concreto,
        // las podéis negar usando el operador ~
        capaPared = ~capaPared;


        RaycastHit hit;

        if (Physics.Raycast(origen, direccion, out hit, Mathf.Infinity, mascara))
        {
          
            // Podemos llamar a la capa del objeto para disernir todavía más, si hiciera falta
            //hit.collider.gameObject.layer;

        }
    }


    void LanzarRayoCamara()
    {
        // Si pulso el botón derecho del ratón...
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition.x + " " + Input.mousePosition.y);

            // Obtengo un rayo desde dicho punto hacia el juego
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            // ¿ He tocado algo?
            if (Physics.Raycast(rayo, out hit))
               {
                  Debug.Log(rayo.origin + " " + rayo.direction);
                  Debug.Log(hit.collider.gameObject.name);
               }


        }
        
    }





    void OnDrawGizmos()
    {
        DrawLine();
        DrawSphere();
        DrawCube();
        DrawWireCube();
    }

    private void DrawWireCube()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position + (Vector3.forward * 15), new Vector3(1, 1, 1));
    }

    void DrawLine()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector3(1,1,1));
    }

    void DrawSphere()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position,5f);
    }

    void DrawCube()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }
}

