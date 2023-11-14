using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray rayo = new Ray(transform.position, transform.forward);

        RaycastHit[] hit;

       /* TODO 2: Investigar qué hace la función RaycastAll, y comprobar que funciona, recorriendo su resultado */
       /* TODO 3: Añadir uno de los objetos a la capa No Raycast, y asignar la mascara de bits de todos menos esa */
       /* Todo 4: Hacer que, de los objetos identificados, aquellos que estén en posiciones pares de la lista acaben de color
        * azul, y los que estén en posiciones impares, de color rojo */
    }

    private void OnDrawGizmos()
    {
        /* TODO 1: Crear un Gizmo que sea un rayo */
    }
}
