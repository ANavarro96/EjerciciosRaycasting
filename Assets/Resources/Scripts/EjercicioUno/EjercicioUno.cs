using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioUno : MonoBehaviour
{
    public int longitudRayo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, 45f * Time.deltaTime);

        /* TODO 2: Lanzar un rayo que salga desde el cubo hacia adelante, y que cambie el color del objeto con el que choca */
    }

    private void OnDrawGizmos()
    {
        /* TODO 1: Crear un Gizmo que sea una linea con longitud longitudRayo */
    }
}
